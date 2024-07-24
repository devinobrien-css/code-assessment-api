using Microsoft.EntityFrameworkCore;
using App.Data;
using App.Models;
using App.ViewModels.Responses;
using App.ViewModels.Requests;

namespace App.Services
{
    public class BookService(ApplicationDbContext context) : IBookService
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<GetBookResponse>> GetBooksAsync()
        {
            var books = await _context.Books.Include(
                b => b.Genre
            )
            .Include(
                b => b.Reviews
            )
            .ThenInclude(
                r => r.User
            )
            .Include(
                b => b.Favorites
            )
            .Include(
                b => b.Transactions
            )
            .ThenInclude(
                t => t.User
            )
            .Select(
                b => new GetBookResponse
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = b.Author,
                    Description = b.Description,
                    Image = b.Image,
                    Genre = new GetBookGenreResponse
                    {
                        Id = b.Genre.Id,
                        Name = b.Genre.Name,
                    },
                    Transactions = b.Transactions.Select(
                        t => new GetBookTransactionResponse
                        {
                            UserId = t.UserId,
                            CheckedInById = t.CheckedInById,
                        }
                    ),
                    Reviews = b.Reviews.Select(
                        r => new GetReviewResponse
                        {
                            Id = r.Id,
                            Rating = r.Rating,
                            Description = r.Description,
                            DateReviewed = r.DateReviewed,
                            Reviewer = new UserReviewResponse
                            {
                                Id = r.User.Id,
                                First = r.User.First,
                                Last = r.User.Last,
                                Email = r.User.Email ?? "",
                                ProfileAvatar = r.User.ProfileAvatar == null ? null : r.User.ProfileAvatar.Url,
                            }
                        }
                    ).OrderByDescending(
                        r => r.DateReviewed
                    ).ToList(),
                    AverageRating = b.Reviews.Average(
                        r => r.Rating
                    ),
                    Favorites = b.Favorites.Select(
                        f => new GetBookFavoritesResponse
                        {
                            UserId = f.UserId,
                        }
                    ),
                    IsAvailable = b.Transactions.All(
                        t => t.CheckedInById != null
                    ),
                    ExpectedReturnDate = b.Transactions.Where(
                        t => t.CheckedInById == null
                    ).Select(
                        t => t.DueTime
                    ).FirstOrDefault().ToString(),
                    Publisher = b.Publisher,
                    ISBN = b.ISBN,
                    Year = b.Year,
                    Pages = b.Pages,
                    IsBestSeller = b.IsBestSeller,
                    IsFeatured = b.IsFeatured,
                    IsNewArrival = b.CreatedAt.Date >= DateTime.Now - TimeSpan.FromDays(28),
                }
            )
            .ToListAsync();

            return books;
        }

        public async Task<GetBookResponse?> GetBookAsync(int id)
        {
            var book = await _context.Books.Include(
                b => b.Genre
            )
            .Include(
                b => b.Reviews
            )
            .ThenInclude(
                r => r.User
            )
            .Include(
                b => b.Favorites
            )
            .Include(
                b => b.Transactions
            )
            .ThenInclude(
                t => t.User
            )
            .Select(
                b => new GetBookResponse
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = b.Author,
                    Description = b.Description,
                    Image = b.Image,
                    Genre = new GetBookGenreResponse
                    {
                        Id = b.Genre.Id,
                        Name = b.Genre.Name,
                    },
                    Transactions = b.Transactions.Select(
                        t => new GetBookTransactionResponse
                        {
                            UserId = t.UserId,
                            CheckedInById = t.CheckedInById,
                        }
                    ),
                    Reviews = b.Reviews.Select(
                        r => new GetReviewResponse
                        {
                            Id = r.Id,
                            Rating = r.Rating,
                            Description = r.Description,
                            DateReviewed = r.DateReviewed,
                            Reviewer = new UserReviewResponse
                            {
                                Id = r.User.Id,
                                First = r.User.First,
                                Last = r.User.Last,
                                Email = r.User.Email ?? "",
                                ProfileAvatar = r.User.ProfileAvatar == null ? "" : r.User.ProfileAvatar.Url,
                            }
                        }
                    ).OrderByDescending(
                        r => r.DateReviewed
                    ).ToList(),
                    AverageRating = b.Reviews.Average(
                        r => r.Rating
                    ),
                    Favorites = b.Favorites.Select(
                        f => new GetBookFavoritesResponse
                        {
                            UserId = f.UserId,
                        }
                    ),
                    IsAvailable = b.Transactions.All(
                        t => t.CheckedInById != null
                    ),
                    ExpectedReturnDate = b.Transactions.Where(
                        t => t.CheckedInById == null
                    ).Select(
                        t => t.DueTime
                    ).FirstOrDefault().ToString(),
                    Publisher = b.Publisher,
                    ISBN = b.ISBN,
                    Year = b.Year,
                    Pages = b.Pages,
                    IsBestSeller = b.IsBestSeller,
                    IsFeatured = b.IsFeatured,
                    IsNewArrival = b.CreatedAt.Date >= DateTime.Now - TimeSpan.FromDays(28),
                }
            ).SingleOrDefaultAsync(
                b => b.Id == id
            );

            if (book == null)
            {
                return null;
            }

            return book;
        }

        public bool BookExists(int id)
        {
            return _context.Books.Any(e => e.Id == id);
        }

        public async Task<Book?> UpdateBookAsync(int bookId, PatchBookRequest book)
        {
            var bookToUpdate = await _context.Books.FindAsync(bookId);
            if (bookToUpdate == null)
            {
                return null;
            }

            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.Publisher = book.Publisher;
            bookToUpdate.ISBN = book.ISBN;
            bookToUpdate.Year = book.Year;
            bookToUpdate.Pages = book.Pages;
            bookToUpdate.GenreId = book.GenreId;
            bookToUpdate.Description = book.Description;
            bookToUpdate.Image = book.Image;
            bookToUpdate.IsBestSeller = book.IsBestSeller;
            bookToUpdate.IsFeatured = book.IsFeatured;
            bookToUpdate.UpdatedAt = DateTime.Now;

            var res = await _context.SaveChangesAsync();

            return bookToUpdate;
        }

        public async Task AddBookAsync(PostBookRequest book)
        {
            _context.Books.Add(new Book
            {
                Title = book.Title,
                Author = book.Author,
                Publisher = book.Publisher,
                ISBN = book.ISBN,
                Year = book.Year,
                Pages = book.Pages,
                GenreId = book.GenreId,
                Description = book.Description,
                Image = book.Image,
                IsBestSeller = book.IsBestSeller,
                CreatedAt = DateTime.Now,
            });
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBookAsync(Book book)
        {
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }
    }

}