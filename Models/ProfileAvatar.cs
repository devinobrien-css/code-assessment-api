namespace code_assessment_api.Models;

public class ProfileAvatar {
    public int Id { get; set; }
    public string Url { get; set; } = string.Empty;

    public ICollection<User> Users { get; set; } = null!;
}