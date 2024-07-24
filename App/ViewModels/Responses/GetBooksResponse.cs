using System.Transactions;
using code_assessment_api.Models;

namespace code_assessment_api.ViewModels.Responses;


public class GetBookGenreResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

}

public class GetBookTransactionResponse
{
    public string UserId { get; set; } = string.Empty;
    public string? CheckedInById { get; set; } = string.Empty;
}

public class GetBookFavoritesResponse
{
    public string UserId { get; set; } = string.Empty;
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
    public IEnumerable<GetBookTransactionResponse>? Transactions { get; set; } = null!;
    public IEnumerable<GetBookFavoritesResponse>? Favorites { get; set; } = null!;
    public IEnumerable<GetReviewResponse>? Reviews { get; set; } = null!;
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