
using App.Data;
using App.Models;
using App.Services;
using App.ViewModels.Responses;
using App.ViewModels.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using Bogus;

namespace App.Controllers;

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
        var user = new User
        {
            UserName = model.Email,
            Email = model.Email,
            First = model.First,
            Last = model.Last,
            ProfileAvatarId = Randomizer.Seed.Next(1, 35)
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

    [HttpGet("email-exists")]
    public async Task<IActionResult> EmailExists(string email)
    {
        var user = await _identityManager.FindByEmailAsync(email);
        return Ok(new { exists = user != null });
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
                ProfileAvatar = u.ProfileAvatar == null ? null : new ProfileAvatar
                {
                    Id = u.ProfileAvatar.Id,
                    Url = u.ProfileAvatar.Url
                },

            }
        ).AsNoTracking()
        .SingleOrDefaultAsync(u => u.Id == identityUser.Id);

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


