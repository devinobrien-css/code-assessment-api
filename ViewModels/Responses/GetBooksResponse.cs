using System.Transactions;
using code_assessment_api.Models;

namespace code_assessment_api.ViewModels.Responses;


public class GetBooksGenreResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

}

public class GetBooksTransactionResponse
{
    public string UserId { get; set; } = string.Empty;
    public string? CheckedInById { get; set; } = string.Empty;
}

public class GetBooksFavoritesResponse
{
    public string UserId { get; set; } = string.Empty;
}

public class GetBooksResponse
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public string? Image { get; set; } = string.Empty;
    public int Year { get; set; }
    public GetBooksGenreResponse Genre { get; set; } = null!;
    public IEnumerable<GetBooksTransactionResponse> Transactions { get; set; } = null!;
    public IEnumerable<GetBooksFavoritesResponse> Favorites { get; set; } = null!;
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