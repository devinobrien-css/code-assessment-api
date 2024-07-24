using System.Runtime.ExceptionServices;

namespace App.ViewModels.Requests;

public class RegisterAccountPayload
{
    public string First { get; set; } = string.Empty;
    public string Last { get; set; } = string.Empty;
    public string ProfilePicture { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public bool IsEmployee { get; set; }
}