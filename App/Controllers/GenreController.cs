using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using code_assessment_api.Models;
using code_assessment_api.Data;

namespace code_assessment_api.Controllers
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
