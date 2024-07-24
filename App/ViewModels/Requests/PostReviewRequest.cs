namespace App.ViewModels.Requests;

public class PostReviewRequest
{
    public int Rating { get; set; }
    public string Description { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;
    public int BookId { get; set; }
}