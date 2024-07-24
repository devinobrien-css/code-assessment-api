namespace App.ViewModels.Requests;

public class PatchBookRequest
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Publisher { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public int Year { get; set; }
    public int Pages { get; set; }
    public int GenreId { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public bool IsBestSeller { get; set; }
    public bool IsFeatured { get; set; }
}