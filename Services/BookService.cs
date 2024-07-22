using Microsoft.EntityFrameworkCore;
using code_assessment_api.Data;
using code_assessment_api.Models;
using code_assessment_api.ViewModels.Responses;
using code_assessment_api.ViewModels.Requests;

namespace code_assessment_api.Services
{
    public class BookService(ApplicationDbContext context) : IBookService
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<GetBooksResponse>> GetBooksAsync()
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
                b => new GetBooksResponse
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = b.Author,
                    Description = b.Description,
                    Image = b.Image,
                    Genre = new GetBooksGenreResponse
                    {
                        Id = b.Genre.Id,
                        Name = b.Genre.Name,
                    },
                    Transactions = b.Transactions.Select(
                        t => new GetBooksTransactionResponse
                        {
                            UserId = t.UserId,
                            CheckedInById = t.CheckedInById,
                        }
                    ),
                    Reviews = b.Reviews.Select(
                        r => new GetBookReviewResponse
                        {
                            Id = r.Id,
                            Rating = r.Rating,
                            Description = r.Description,
                            DateReviewed = r.DateReviewed,
                            Reviewer = r.User.ProfileAvatar == null ? null : new GetBookReviewUserResponse
                            {
                                Id = r.User.Id,
                                First = r.User.First,
                                Last = r.User.Last,
                                Email = r.User.Email ?? "",
                                ProfileAvatar = r.User.ProfileAvatar.Url,
                            }
                        }
                    ).OrderByDescending(
                        r => r.DateReviewed
                    ).ToList(),
                    AverageRating = b.Reviews.Average(
                        r => r.Rating
                    ),
                    Favorites = b.Favorites.Select(
                        f => new GetBooksFavoritesResponse
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
            var user = await _context.Books.Include(
                b => b.Genre
            ).Include(
                b => b.Reviews
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
                    Reviews = b.Reviews.Select(
                        r => new GetBookReviewResponse
                        {
                            Id = r.Id,
                            Rating = r.Rating,
                            Description = r.Description,
                            DateReviewed = r.DateReviewed,
                            Reviewer = r.User.ProfileAvatar == null ? null : new GetBookReviewUserResponse
                            {
                                Id = r.User.Id,
                                First = r.User.First,
                                Last = r.User.Last,
                                Email = r.User.Email ?? "",
                                ProfileAvatar = r.User.ProfileAvatar.Url,
                            }
                        }
                    ).OrderByDescending(
                        r => r.DateReviewed
                    ).ToList(),
                    AverageRating = b.Reviews.Average(
                        r => r.Rating
                    ),
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

            if (user == null)
            {
                return null;
            }

            return user;
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