using App.ViewModels.Requests;
using App.ViewModels.Responses;

namespace App.Services
{
    public interface ITransactionService
    {
        public Task PostTransactionAsync(PostTransactionRequest transaction);

        public Task<IEnumerable<UserTransactionResponse>> GetAllUserTransactionsAsync();

        public Task<UserTransactionResponse?> GetUserTransactionAsync(int id);
    }

}