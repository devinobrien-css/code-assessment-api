
using code_assessment_api.Data;
using code_assessment_api.Models;
using code_assessment_api.Services;
using code_assessment_api.ViewModels.Responses;
using code_assessment_api.ViewModels.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;

namespace code_assessment_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountController(ApplicationDbContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager) : ControllerBase
{
    private readonly ApplicationDbContext _context = context;
    private readonly UserManager<User> _identityManager = userManager;
    private readonly RoleManager<IdentityRole> _roleManager = roleManager;

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterAccountPayload model)
    {
        var user = new User { 
            UserName = model.Email, 
            Email = model.Email,
            First = model.First,
            Last = model.Last,
        };
        var result = await _identityManager.CreateAsync(user, model.Password);

        if (result.Succeeded)
        {
            string role = model.IsEmployee ? "Employee" : "Customer";
            if (!await _roleManager.RoleExistsAsync(role))
            {
                await _roleManager.CreateAsync(new IdentityRole(role));
            }

            await _identityManager.AddToRoleAsync(user, role);

            return Ok(new { message = "User registered successfully" });
        } 

        return BadRequest(result.Errors);
    }

    [Authorize]
    [HttpGet("current-user")]
    public async Task<IActionResult> GetUserInfo()
    {
        var identityUser = await _identityManager.GetUserAsync(User);
        if (identityUser == null)
        {
            return NotFound("User not found");
        }

        var roles = await _identityManager.GetRolesAsync(identityUser);

        var user = await _context.Users.Include(
            u => u.ProfileAvatar
        ).Select(
            u => new User
            {
                Id = u.Id,
                First = u.First,
                Last = u.Last,
                Email = u.Email,
                ProfileAvatar = new ProfileAvatar
                {
                    Id = u.ProfileAvatar.Id,
                    Url = u.ProfileAvatar.Url
                }
            }
        ).AsNoTracking()
        .SingleOrDefaultAsync(u => u.Id == identityUser.Id);

        Console.WriteLine("-0-0-0-0-0-");
        Console.WriteLine(user.ToJson());

        var userInfo = new UserInfoResponse
        {
            Id = identityUser.Id,
            First = user?.First ?? "",
            Last = user?.Last ?? "",
            Email = user?.Email ?? "",
            ProfileAvatar = new ProfileAvatarResponse
            {
                Id = user?.ProfileAvatar?.Id ?? 0,
                Url = user?.ProfileAvatar?.Url ?? ""
            },
            Roles = [.. roles]
        };

        return Ok(userInfo);
    }
}


