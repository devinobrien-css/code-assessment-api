using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using code_assessment_api.Models;
using Microsoft.AspNetCore.Authorization;
using code_assessment_api.Data;
using NuGet.Protocol;
using code_assessment_api.Services;
using code_assessment_api.ViewModels.Responses;
using code_assessment_api.ViewModels.Requests;

namespace code_assessment_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;
        private readonly BookService _bookService = new(context);

        // GET: api/Book
        [HttpGet]
        public async Task<ActionResult<List<GetBooksResponse>>> GetBooks()
        {
            var books = await _bookService.GetBooksAsync();
            return Ok(books);
        }

        // GET: api/Book/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        // PUT: api/Book/5
        [HttpPut("{id}")]
        [Authorize(Roles = "sEmployee")]
        public async Task<IActionResult> PutBook(int id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Book
        [HttpPost]
        [Authorize(Roles = "Employee")]
        public async Task<ActionResult<Book>> PostBook(PostBookRequest book)
        {   
            Console.WriteLine("------------------");
            Console.WriteLine("Book: " + book.ToJson());
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
    }
}
