namespace code_assessment_api.ViewModels.Responses;

public class UserReviewResponse
{
    public string Id { get; set; } = string.Empty;
    public string First { get; set; } = string.Empty;
    public string Last { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string ProfileAvatar { get; set; } = string.Empty;
}

public class BookReviewResponse
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
}

public class GetReviewResponse
{
    public int Id { get; set; }
    public int Rating { get; set; }
    public string Description { get; set; } = string.Empty;

    public UserReviewResponse Reviewer { get; set; } = null!;
    public BookReviewResponse Book { get; set; } = null!;
}