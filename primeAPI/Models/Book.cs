namespace primeAPI.Models
{
    public class Book
    {
        public int id { get; set; }
        public string Title { get; set; } = null!;
        public  string Author { get; set; } = null!;
        public int YearPublished { get; set; }
    }
}
