using System;
using System.Collections;
using System.Collections.Generic;

namespace R53_Group_A.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Biography { get; set; } //country of origin, famous for, brief description
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool? IsActive { get; set; }
        //public virtual ICollection<BookAuthor> BookAuthor { get; set; }
        //public virtual ICollection<UserPreference> UserPreference { get; set; }
        
    }
}
