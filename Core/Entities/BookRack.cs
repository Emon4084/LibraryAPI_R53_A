namespace LibraryAPI_R53_A.Core.Domain
{
    public class BookRack
    {
        public int BookRackId { get; set; }
        public string? BookRackName { get; set; }
        public int ShelfId { get; set; }
        public Shelf? Shelf { get; set; }
    }

}
