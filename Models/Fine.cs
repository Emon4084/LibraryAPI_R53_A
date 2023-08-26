using System;

namespace R53_Group_A.Models
{
    public class Fine
    {

        public int FineId { get; set; }
        public int BorrowedBookId { get; set; }
        public BorrowedBook? BorrowedBook { get; set; }
        public decimal FineAmount { get; set; }
        public DateTime? PaidDate { get; set; }
        public bool IsPaid { get; set; }
        public bool IsActive { get; set; }
    }
}
