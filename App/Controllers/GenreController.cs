using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using App.Models;
using App.Data;

namespace App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenreController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        // GET: api/Genre
        [HttpGet]
        public async Task<ActionResult<List<Genre>>> GetGenres()
        {
            var genres = await _context.Genres.ToListAsync();

            return Ok(genres);
        }
    }
}
