
namespace code_assessment_api.ViewModels.Responses;


public class ProfileAvatarResponse
{
    public int Id { get; set; }
    public string Url { get; set; } = string.Empty;
}

public class UserInfoResponse
{
    public string Id { get; set; } = string.Empty;
    public string First { get; set; } = string.Empty;
    public string Last { get; set; } = string.Empty;
    public ProfileAvatarResponse? ProfileAvatar { get; set; } = null!;
    public string Email { get; set; } = string.Empty;
    public List<string> Roles { get; set; } = [];
}
