namespace code_assessment_api.Models;

public class UserFavoritesBook
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;
    public string UserId { get; set; } = string.Empty;
    public User User { get; set; } = null!;
}