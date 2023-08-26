using System.Collections.Generic;

namespace R53_Group_A.Models
{
    public class BookFloor
    {
        public int BookFloorId { get; set; }
        public string? BookFloorName { get; set; }
        public bool IsActive { get; set; }
        public virtual List<Shelf> Shelfes { get; set; } = new List<Shelf>();
    }
}
