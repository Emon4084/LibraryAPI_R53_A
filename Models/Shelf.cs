using System.Collections.Generic;

namespace R53_Group_A.Models
{
    public class Shelf
    {
        public int ShelfId { get; set; }
        public bool IsActive { get; set; }
        public string? ShelfName { get; set; }
        public int BookFloorId { get; set; }
        public BookFloor? BookFloor { get; set; }
        public List<BookCopy> Copies { get; set; } = new List<BookCopy>();
        public virtual List<BookRack> BookRacks { get; set; } = new List<BookRack>();
    }
}
