namespace R53_Group_A.Models
{
    public class Inspection
    {
        public int InspectionId { get; set; }
        public string? Comment { get; set; }
        public bool IsActive { get; set; }
        public int BookCopyId { get; set; }
        public BookCopy? BookCopy { get; set; }
        public int BorrowBookId { get; set; }
        public BorrowedBook? BorrowedBook { get; set; }
    }
}
//extra fine will be added to user based on condition checking manually and comment property will include that extra details
