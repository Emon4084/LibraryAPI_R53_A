namespace R53_Group_A.Models
{
    public class BookReview
    {
        public int BookReviewId { get; set; }
        public int BookId { get; set; }
        public Book? Book { get; set; }
        public string? UserId { get; set; }
        public UserInfo? UserInfo { get; set; }
        public string? Comments { get; set; }
        public bool IsActive { get; set; }
    }
}
