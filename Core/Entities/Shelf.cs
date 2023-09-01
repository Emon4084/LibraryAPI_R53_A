using System.Collections.Generic;

namespace LibraryAPI_R53_A.Core.Domain
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
