namespace GreenFieldLib.Models
{
    public class LibraryBook
    {
        public int BookID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public int NumberOfCopies { get; set; }
    }
}
