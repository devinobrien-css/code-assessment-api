using code_assessment_api.ViewModels.Requests;
using code_assessment_api.ViewModels.Responses;

namespace code_assessment_api.Services {
    public interface ITransactionService
    {
        public Task PostTransactionAsync(PostTransactionRequest transaction);

         public Task<IEnumerable<UserTransactionResponse>> GetAllUserTransactionsAsync();

          public Task<UserTransactionResponse?> GetUserTransactionAsync(int id);
    }

}