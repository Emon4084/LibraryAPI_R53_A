namespace R53_Group_A.Models
{
    public class BookRack
    {
        public int BookRackId { get; set; }
        public string? BookRackName { get; set; }
        public int ShelfId { get; set; }
        public Shelf? Shelf { get; set; }
    }

}
