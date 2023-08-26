using System.ComponentModel.DataAnnotations;

namespace R53_Group_A.Models
{
    public class BookAuthor
    {
        
        public bool IsActive { get; set; }

        public int BookId { get; set; }

        public Book? Book { get; set; }
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}
