﻿using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace R53_Group_A.Models
{
    public class BorrowedBook
    {
        [Key]
        public int BorrowedBookId { get; set; }
        public string? UserId { get; set; }
        public UserInfo? UserInfo { get; set; }
        public int? BookId { get; set; }
        public Book? Book { get; set; }
        public int BookCopyId { get; set; }
        public BookCopy? BookCopy { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }

        public bool IsReturned { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ActualReturnDate { get; set; }
        //public System.Collections.Generic.ICollection<Inspection>? Inspection { get; set; }
        //public System.Collections.Generic.ICollection<Fine>? Fine { get; set; }


    }
}
