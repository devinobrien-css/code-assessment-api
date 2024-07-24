
namespace code_assessment_api.ViewModels.Responses;


public class GetUserFavoritesResponse
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string? Image { get; set; } = string.Empty;
    public bool IsAvailable { get; set; }
    public string? ExpectedReturnDate { get; set; } = string.Empty;

}