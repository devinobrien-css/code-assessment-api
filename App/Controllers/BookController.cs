using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using App.Models;
using Microsoft.AspNetCore.Authorization;
using App.Data;
using NuGet.Protocol;
using App.Services;
using App.ViewModels.Responses;
using App.ViewModels.Requests;


namespace App.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class BookController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;
        private readonly BookService _bookService = new(context);

        // GET: api/Book
        [HttpGet]
        public async Task<ActionResult<List<GetBookResponse>>> GetBooks()
        {
            var books = await _bookService.GetBooksAsync();
            return Ok(books);
        }

        // GET: api/Book/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            if (!BookExists(id))
            {
                return NotFound();
            }

            var book = await _bookService.GetBookAsync(id);
            return Ok(book);
        }

        // PATCH: api/Book/5
        [HttpPatch("{id}")]
        [Authorize(Roles = "Employee")]
        public async Task<IActionResult> PatchBook(int id, PatchBookRequest book)
        {
            await _bookService.UpdateBookAsync(id, book);
            return NoContent();
        }

        // POST: api/Book
        [HttpPost]
        [Authorize(Roles = "Employee")]
        public async Task<ActionResult<Book>> PostBook(PostBookRequest book)
        {
            await _bookService.AddBookAsync(book);
            return NoContent();
        }

        // DELETE: api/Book/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Employee")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.Id == id);
        }

        // POST: api/Book/{id}/review
        [HttpPost("{id}/review")]
        public async Task<ActionResult> PostReview(int id, PostReviewRequest review)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            var newReview = new Review
            {
                Rating = review.Rating,
                Description = review.Description,
                UserId = review.UserId,
                DateReviewed = DateTime.Now.ToString(),
                BookId = id
            };


            await _context.Reviews.AddAsync(newReview);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
