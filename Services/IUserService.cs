using code_assessment_api.Models;
using code_assessment_api.Services;

namespace code_assessment_api.Services {
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User?> GetUserAsync(long id);
        Task<User?> UpdateUserAsync(User user);
        Task AddUserAsync(User user);
        Task DeleteUserAsync(User user);
        bool UserExists(long id);
    }

}