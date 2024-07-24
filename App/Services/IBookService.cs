using App.Models;
using App.Services;
using App.ViewModels.Requests;
using App.ViewModels.Responses;

namespace App.Services
{
    public interface IBookService
    {
        Task<List<GetBookResponse>> GetBooksAsync();
        Task<GetBookResponse?> GetBookAsync(int id);
        Task<Book?> UpdateBookAsync(int bookId, PatchBookRequest book);
        Task AddBookAsync(PostBookRequest book);
        Task DeleteBookAsync(Book book);
        bool BookExists(int id);
    }

}