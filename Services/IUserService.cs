using code_assessment_api.Models;
using code_assessment_api.ViewModels.Requests;
using code_assessment_api.ViewModels.Responses;

namespace code_assessment_api.Services
{
    public interface IUserService
    {
        Task<IEnumerable<GetUserResponse>> GetUsersAsync();
        Task<User?> GetUserAsync(string id);
        Task UpdateUserAsync(string userId, UpdateUserRequest newData);
        Task AddUserAsync(User user);
        Task DeleteUserAsync(User user);
        bool UserExists(string id);
        public Task<IEnumerable<ProfileAvatar>> GetProfileAvatarsAsync();
        public Task SetProfileAvatarsAsync(int avatarId, string userId);
        public Task UserFavoritesBookAsync(int bookId, string userId);
        public Task UserUnfavoritesBookAsync(int bookId, string userId);
        public Task<IEnumerable<GetUserFavoritesResponse>> GetUserFavoriteBooksAsync(string userId);
    }

}