using System;
using System.Collections.Generic;

namespace R53_Group_A.Models
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
