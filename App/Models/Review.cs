namespace code_assessment_api.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; } = string.Empty;

        public string DateReviewed { get; set; } = string.Empty;

        public string UserId { get; set; } = string.Empty;
        public User User { get; set; } = null!;

        public int BookId { get; set; }
        public Book Book { get; set; } = null!;
    }
}