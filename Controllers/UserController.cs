using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using code_assessment_api.Models;
using code_assessment_api.Services;

namespace code_assessment_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(UserContext context) : ControllerBase
    {
        private readonly UserService _userService = new(context);

        // GET: api/User
        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _userService.GetUsersAsync();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(long id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var user = await _userService.GetUserAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/User/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(long id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            if(!_userService.UserExists(id))
            {
                return NotFound();
            }

            var updatedUser = await _userService.UpdateUserAsync(user);

            if (updatedUser == null)
            {
                return StatusCode(500, "Failed to update user");
            }

            return NoContent();
        }

        // POST: api/User
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            await _userService.AddUserAsync(user);

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // // DELETE: api/User/5
        // [HttpDelete("{id}")]
        // public async Task<IActionResult> DeleteUser(long id)
        // {
        //     var user = await _context.Users.FindAsync(id);
        //     if (user == null)
        //     {
        //         return NotFound();
        //     }

        //     _context.Users.Remove(user);
        //     await _context.SaveChangesAsync();

        //     return NoContent();
        // }
    }
}
