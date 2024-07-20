using code_assessment_api.Services;
using Microsoft.AspNetCore.Identity;

namespace code_assessment_api.Models;

public class User : IdentityUser
{
    public string First { get; set; } = string.Empty;
    public string Last { get; set; } = string.Empty;
    public int? ProfileAvatarId { get; set; }
    public ProfileAvatar ProfileAvatar { get; set; } = null!;
    public ICollection<BookTransaction> Transactions { get; } = new List<BookTransaction>();
    public ICollection<UserFavoritesBook> Favorites { get; } = new List<UserFavoritesBook>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}