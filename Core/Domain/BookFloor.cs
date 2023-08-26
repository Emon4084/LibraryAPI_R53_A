using System.Collections.Generic;

namespace LibraryAPI_R53_A.Core.Domain
{
    public class BookFloor
    {
        public int BookFloorId { get; set; }
        public string? BookFloorName { get; set; }
        public bool IsActive { get; set; }
        public virtual List<Shelf> Shelfes { get; set; } = new List<Shelf>();
    }
}
