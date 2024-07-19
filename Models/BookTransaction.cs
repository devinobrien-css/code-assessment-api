namespace code_assessment_api.Models;

public class BookTransaction
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;
    public string UserId { get; set; } = string.Empty;
    public User User { get; set; } = null!;
    public DateTime CheckOutTime { get; set; }
    public DateTime? DueTime { get; set; }
    public DateTime? CheckInTime { get; set; }
    public string? CheckedOutById { get; set; } = string.Empty;
    public User? CheckedOutBy { get; set; } = null!;
    public string? CheckedInById { get; set; } = string.Empty;
    public User? CheckedInBy { get; set; } = null!;
}