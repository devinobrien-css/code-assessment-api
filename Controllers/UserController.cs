using Microsoft.AspNetCore.Mvc;
using code_assessment_api.Models;
using code_assessment_api.Services;
using Microsoft.AspNetCore.Authorization;
using code_assessment_api.Data;
using Microsoft.AspNetCore.Identity;
using code_assessment_api.ViewModels.Requests;
using code_assessment_api.ViewModels.Responses;

namespace code_assessment_api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class UserController(ApplicationDbContext context, UserManager<User> userManager) : ControllerBase
    {
        private readonly UserManager<User> _identityManager = userManager;
        private readonly UserService _userService = new(context, userManager);
        private readonly BookService _bookService = new(context);

        // GET: api/User
        [HttpGet]
        public async Task<IEnumerable<GetUserResponse>> GetUsers()
        {
            return await _userService.GetUsersAsync();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetUserResponse>> GetUser(string id)
        {
            if (id == null)
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

        // PATCH: api/User/5
        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchUser(string id, UpdateUserRequest user)
        {
            var identityUser = await _identityManager.GetUserAsync(User);
            if (identityUser == null)
            {
                return NotFound("User not found");
            }
            if (id != identityUser.Id)
            {
                return BadRequest();
            }

            if (!_userService.UserExists(id))
            {
                return NotFound();
            }

            await _userService.UpdateUserAsync(id, user);

            return NoContent();
        }

        // POST: api/User
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            await _userService.AddUserAsync(user);

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // GET: api/User/avatars
        [HttpGet("avatars")]
        public async Task<IEnumerable<ProfileAvatar>> GetProfileAvatars()
        {
            return await _userService.GetProfileAvatarsAsync();
        }

        // POST: api/User/5/avatar/2
        [HttpPost("{userId}/avatar/{avatarId}")]
        public async Task<ActionResult> SetProfileAvatar(string userId, int avatarId)
        {
            var identityUser = await _identityManager.GetUserAsync(User);
            if (identityUser == null)
            {
                return NotFound("User not found");
            }
            else if (identityUser.Id != userId)
            {
                return Unauthorized();
            }

            await _userService.SetProfileAvatarsAsync(avatarId, userId);
            return NoContent();
        }

        // GET: api/User/5/favorite
        [HttpGet("{userId}/favorite")]
        public async Task<IEnumerable<GetUserFavoritesResponse>> GetUserFavoriteBooks(string userId)
        {
            return await _userService.GetUserFavoriteBooksAsync(userId);
        }

        // POST: api/User/5/favorite/2
        [HttpPost("{userId}/favorite/{bookId}")]
        public async Task<ActionResult> UserFavoritesBook(string userId, int bookId)
        {
            var identityUser = await _identityManager.GetUserAsync(User);
            if (identityUser == null)
            {
                return NotFound("User not found");
            }
            else if (identityUser.Id != userId)
            {
                return Unauthorized();
            }


            var book = await _bookService.GetBookAsync(bookId);
            if (book == null)
            {
                return NotFound("Book not found");
            }

            await _userService.UserFavoritesBookAsync(bookId, userId);

            return NoContent();
        }

        // DELETE: api/User/5/favorite/2
        [HttpDelete("{userId}/favorite/{bookId}")]
        public async Task<ActionResult> UserUnfavoritesBook(string userId, int bookId)
        {
            var identityUser = await _identityManager.GetUserAsync(User);
            if (identityUser == null)
            {
                return NotFound("User not found");
            }
            else if (identityUser.Id != userId)
            {
                return Unauthorized();
            }

            var book = await _bookService.GetBookAsync(bookId);
            if (book == null)
            {
                return NotFound("Book not found");
            }

            await _userService.UserUnfavoritesBookAsync(bookId, userId);

            return NoContent();
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Employee")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _userService.GetUserAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            await _userService.DeleteUserAsync(new User {
                Id = user.Id,
                First = user.First,
                Last = user.Last,
                Email = user.Email,
            });

            return NoContent();
        }

        // GET: api/User/5/transactions
        [HttpGet("{id}/transactions")]
        public async Task<IActionResult> GetUserTransactions(string id)
        {
            var user = await _identityManager.GetUserAsync(User);
            if (user == null)
            {
                return BadRequest();
            }
            else if (user.Id != id)
            {
                return Unauthorized();
            }

            var transactions = await _userService.GetUserTransactionsAsync(id);

            return Ok(transactions);
        }
    }
}
