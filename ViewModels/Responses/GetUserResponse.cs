
namespace code_assessment_api.ViewModels.Responses;
public class GetUserResponse
{
    public string Id { get; set; } = string.Empty;
    public string First { get; set; } = string.Empty;
    public string Last { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? ProfileAvatar { get; set; } = null!;
    public IEnumerable<string>? Roles { get; set; } = null!;
    public IEnumerable<UserTransactionResponse>? Transactions { get; set; } = null!;
}

