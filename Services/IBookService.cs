using code_assessment_api.Models;
using code_assessment_api.Services;
using code_assessment_api.ViewModels.Requests;
using code_assessment_api.ViewModels.Responses;

namespace code_assessment_api.Services {
    public interface IBookService
    {
        Task<List<GetBooksResponse>> GetBooksAsync();
        Task<Book?> GetBookAsync(int id);
        Task<Book?> UpdateBookAsync(Book book);
        Task AddBookAsync(PostBookRequest book);
        Task DeleteBookAsync(Book book);
        bool BookExists(int id);
    }

}