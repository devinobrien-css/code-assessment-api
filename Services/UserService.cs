using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using code_assessment_api.Models;
using code_assessment_api.Services;

namespace code_assessment_api.Services
{
    public class UserService : IUserService
    {
        public UserService(UserContext context)
        {
            _context = context;
        }

        private readonly UserContext _context;

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetUserAsync(long id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return null;
            }

            return user;
        }

        public bool UserExists(long id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

        public async Task<User?> UpdateUserAsync(User user)
        {
            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }

            return user;
        }

        public async Task AddUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return;
        }
        
        // public async bool DeleteUserAsync(User user)
        // {
        //     _context.Users.Remove(user);
        //     await _context.SaveChangesAsync();

        //     return true;
        // }

        // public async bool UserExists(long id)
        // {
        //     return await _context.Users.AnyAsync(e => e.Id == id);
        // }
    }

}