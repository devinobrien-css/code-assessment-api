using App.Models;
using App.ViewModels.Requests;
using App.ViewModels.Responses;

namespace App.Services
{
    public interface IUserService
    {
        Task<IEnumerable<GetUserResponse>> GetUsersAsync();
        Task<GetUserResponse?> GetUserAsync(string id);
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