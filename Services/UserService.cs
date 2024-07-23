using Microsoft.EntityFrameworkCore;
using code_assessment_api.Data;
using code_assessment_api.Models;
using code_assessment_api.ViewModels.Responses;
using code_assessment_api.ViewModels.Requests;
using Microsoft.AspNetCore.Identity;

namespace code_assessment_api.Services
{
    public class UserService(ApplicationDbContext context, UserManager<User> userManager) : IUserService
    {
        private readonly ApplicationDbContext _context = context;
        private readonly UserManager<User> _identityManager = userManager;

        public async Task<IEnumerable<GetUserResponse>> GetUsersAsync()
        {
            var users = await _context.Users.Include(
                u => u.ProfileAvatar
            )
            .Select(
                u => new User
                {
                    Id = u.Id,
                    First = u.First,
                    Last = u.Last,
                    Email = u.Email,
                    ProfileAvatar = u.ProfileAvatar ?? new ProfileAvatar {
                        Id = 0,
                        Url = "https://robohash.org/55"
                    },
                }
            ).ToListAsync();

            var identityUsers = new List<GetUserResponse>();

            for (int i = 0; i < users.Count; i++)
            {
                var identityUser = await _identityManager.FindByIdAsync(users[i].Id);

                if (identityUser != null)
                {
                    var roles = await _identityManager.GetRolesAsync(identityUser);
                    identityUsers.Add(new GetUserResponse
                    {
                        Id = users[i].Id,
                        First = users[i].First,
                        Last = users[i].Last,
                        Email = users[i].Email ?? "",
                        ProfileAvatar = users[i].ProfileAvatar == null ? "https://robohash.org/55" : users[i].ProfileAvatar?.Url,
                        Roles = roles
                    });
                }
            }

            return identityUsers;
        }

        public async Task<User?> GetUserAsync(string id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return null;
            }

            return user;
        }

        public bool UserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

        public async Task UpdateUserAsync(string userId, UpdateUserRequest newData)
        {
            var user = await _context.Users.FindAsync(userId);

            if (user != null)
            {
                user.First = newData.First;
                user.Last = newData.Last;
                var res = await _context.SaveChangesAsync();
            }

        }

        public async Task AddUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProfileAvatar>> GetProfileAvatarsAsync()
        {
            return await _context.ProfileAvatars.ToListAsync();
        }

        public async Task SetProfileAvatarsAsync(int avatarId, string userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user != null)
            {
                user.ProfileAvatarId = avatarId;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UserFavoritesBookAsync(int bookId, string userId)
        {
            var userFavoritesBook = new UserFavoritesBook
            {
                UserId = userId,
                BookId = bookId
            };

            _context.UserFavoritesbooks.Add(userFavoritesBook);
            await _context.SaveChangesAsync();
        }

        public async Task UserUnfavoritesBookAsync(int bookId, string userId)
        {
            var userFavoritesBook = await _context.UserFavoritesbooks
                .Where(ufb => ufb.UserId == userId && ufb.BookId == bookId)
                .FirstOrDefaultAsync();

            if (userFavoritesBook != null)
            {
                _context.UserFavoritesbooks.Remove(userFavoritesBook);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<GetUserFavoritesResponse>> GetUserFavoriteBooksAsync(string userId)
        {
            return await _context.UserFavoritesbooks
                .Where(ufb => ufb.UserId == userId)
                .Include(ufb => ufb.Book)
                .ThenInclude(b => b.Transactions)
                .Select(
                    ufb => new GetUserFavoritesResponse
                    {
                        Id = ufb.Book.Id,
                        Title = ufb.Book.Title,
                        Author = ufb.Book.Author,
                        Image = ufb.Book.Image,
                        IsAvailable = ufb.Book.Transactions.All(t => t.CheckedInById != null),
                        ExpectedReturnDate = ufb.Book.Transactions.Where(t => t.CheckedInById == null).Select(t => t.DueTime).FirstOrDefault().ToString(),
                    }
                )
                .ToListAsync();
        }

        public async Task<IEnumerable<UserTransactionResponse>> GetUserTransactionsAsync(string userId)
        {
            return await _context.BookTransactions
                .Where(ut => ut.UserId == userId)
                .Select(ut => new UserTransactionResponse
                {
                    Id = ut.Id,
                    Book = ut.Book,
                    CheckOutTime = ut.CheckOutTime,
                    DueTime = ut.DueTime,
                    CheckedOutBy = new TransactionUserResponse
                    {
                        Id = ut.CheckedOutById ?? "",
                        First = ut.CheckedOutBy!.First ?? "",
                        Last = ut.CheckedOutBy!.Last ?? ""
                    },
                    CheckedInBy = new TransactionUserResponse
                    {
                        Id = ut.CheckedInById ?? "",
                        First = ut.CheckedInBy!.First ?? "",
                        Last = ut.CheckedInBy!.Last ?? ""
                    },
                    IsCheckedIn = ut.CheckedInById != null,
                    IsOverdue = ut.DueTime < DateTime.Now && ut.CheckedInById == null
                }).OrderByDescending(ut => ut.DueTime)
                .ToListAsync();
        }
    }

}