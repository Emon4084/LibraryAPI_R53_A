using System;
using System.Collections.Generic;

namespace LibraryAPI_R53_A.Core.Domain
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string? PublisherName { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        //public ICollection<Book>? Books { get; set; }
    }
}
