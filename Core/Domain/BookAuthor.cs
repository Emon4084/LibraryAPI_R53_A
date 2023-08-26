using System.ComponentModel.DataAnnotations;

namespace LibraryAPI_R53_A.Core.Domain
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
