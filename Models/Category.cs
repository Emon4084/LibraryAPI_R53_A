using System.Collections.Generic;

namespace R53_Group_A.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? DDCCode { get; set; }
        public bool IsActive { get; set; }

        public virtual List<Subcategory> Subcategories { get; set;} = new List<Subcategory> ();
        //public virtual ICollection<Book>? Books { get; set; }
        //public virtual ICollection<UserPreference>? UserPreference { get; set; }
        
    }
}
