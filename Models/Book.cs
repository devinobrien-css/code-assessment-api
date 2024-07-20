namespace code_assessment_api.Models;

public class Book {
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    
    public int GenreId { get; set; } 
    public Genre Genre { get; set; } = null!;

    public ICollection<BookTransaction> Transactions { get; } = new List<BookTransaction>();
    public ICollection<UserFavoritesBook> Favorites { get; } = new List<UserFavoritesBook>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
    public int Year { get; set; }
    public int Pages { get; set; }
    public string Publisher { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;

    public string? Description { get; set; } = string.Empty;
    public string? Image { get; set; } = string.Empty;

    public bool IsBestSeller { get; set; }
    public bool IsFeatured { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}