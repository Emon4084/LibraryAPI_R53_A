using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace R53_Group_A.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? ISBN { get; set; }
        public int? PublisherId { get; set; }
        public Publisher? Publisher { get; set; }
        public DateTime PublishedYear { get; set; }
        public string? Edition { get; set; }
        public int? TotalCopies { get; set; }
        public string? Language { get; set; }
        public string? Description { get; set; }
        [NotMapped]
        public decimal BookPrice { get; set; }
        public decimal? RentPrice { get; set; }
        public string? DDCCode { get; set; }
        public bool IsActive { get; set; }
        [NotMapped] 
        public IFormFile? Cover { get; set; }
        public bool IsDigital { get; set; }
        [NotMapped]
        public IFormFile? EBook { get; set; }
        public bool PublisherAgreement { get; set; }
        [NotMapped]
        public IFormFile? AgreementBookCopy { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        //public ICollection<BookAuthor>? BookAuthor { get; set; }
        
        public List<BookCopy> Copies { get; set; } = new List<BookCopy>();

        //public virtual ICollection<BookReview>? BookReviews { get; set; }
        //public virtual ICollection<BookWishlist>? BookWishlists { get; set; }
        //public virtual ICollection<BorrowedBook>? BorrowedBooks { get; set;}
    }
}
