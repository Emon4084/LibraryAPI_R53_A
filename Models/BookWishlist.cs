namespace R53_Group_A.Models
{
    public class BookWishlist
    {
        public int BookWishlistId { get; set; }
        public bool IsActive { get; set; }
        public string? UserId { get; set; }
        public UserInfo? UserInfo { get; set; }
        public int? BookId { get; set; }
        public Book? Book { get; set; }
    }
}
