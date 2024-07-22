using System.Transactions;
using code_assessment_api.Models;

namespace code_assessment_api.ViewModels.Responses;


public class GetBookGenreResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

}

public class GetBookReviewUserResponse
{
    public string Id { get; set; } = string.Empty;
    public string First { get; set; } = string.Empty;
    public string Last { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? ProfileAvatar { get; set; } = string.Empty;
}

public class GetBookReviewResponse
{
    public int Id { get; set; }
    public int Rating { get; set; }
    public string Description { get; set; } = string.Empty;
    public string DateReviewed { get; set; } = string.Empty;
    public GetBookReviewUserResponse? Reviewer { get; set; } = null!;
}

public class GetBookTransactionResponse
{
    public string UserId { get; set; } = string.Empty;
    public string? CheckedInById { get; set; } = string.Empty;
}

public class GetBookResponse
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public string? Image { get; set; } = string.Empty;
    public int Year { get; set; }
    public GetBookGenreResponse Genre { get; set; } = null!;
    public IEnumerable<GetBookTransactionResponse> Transactions { get; set; } = null!;
    public IEnumerable<GetBookReviewResponse> Reviews { get; set; } = null!;
    public double? AverageRating { get; set; }
    public bool IsAvailable { get; set; }
    public string? ExpectedReturnDate { get; set; } = string.Empty;
    public string Publisher { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public int Pages { get; set; }
    public bool IsBestSeller { get; set; }
    public bool IsNewArrival { get; set; }
    public bool IsFeatured { get; set; }
    public bool IsDeleted { get; set; }

}