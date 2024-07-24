
using code_assessment_api.Models;

namespace code_assessment_api.ViewModels.Responses;

public class TransactionUserResponse
{
    public string Id { get; set; } = string.Empty;
    public string First { get; set; } = string.Empty;
    public string Last { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public ProfileAvatar? ProfileAvatar { get; set; } = null!;
}

public class UserTransactionResponse
{
    public int Id { get; set; }
    public TransactionUserResponse User { get; set; } = null!;
    public Book Book { get; set; } = null!;
    public DateTime CheckOutTime { get; set; }
    public DateTime? CheckInTime { get; set; }

    public DateTime? DueTime { get; set; }
    public TransactionUserResponse? CheckedOutBy { get; set; }
    public TransactionUserResponse? CheckedInBy { get; set; }
    public bool IsCheckedIn { get; set; }
    public bool IsOverdue { get; set; }
}