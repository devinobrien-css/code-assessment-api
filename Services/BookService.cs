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
                    Genre = new GetBooksGenreResponse{
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
                    IsNewArrival = b.IsNewArrival,
                    IsFeatured = b.IsFeatured,
                    IsDeleted = b.IsDeleted,
                }
            )
            .ToListAsync();

            return books;
        }

        public async Task<Book?> GetBookAsync(int id)
        {
            var user = await _context.Books.FindAsync(id);

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

        public async Task<Book?> UpdateBookAsync(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }

            return book;
        }

        public async Task AddBookAsync(PostBookRequest book)
        {
            Console.WriteLine("IN SERVICE AddBookAsync");
            _context.Books.Add(new Book{
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
            });
            var res = await _context.SaveChangesAsync();
            Console.WriteLine("RES: " + res);
        }
        
        public async Task DeleteBookAsync(Book book)
        {
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }
    }

}