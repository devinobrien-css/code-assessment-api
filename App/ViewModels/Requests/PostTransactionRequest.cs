
namespace App.ViewModels.Requests;

public class PostTransactionRequest
{
    public string UserId { get; set; } = string.Empty;
    public int BookId { get; set; }
}