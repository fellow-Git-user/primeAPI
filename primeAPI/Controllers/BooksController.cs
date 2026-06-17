using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using primeAPI.Models;

namespace primeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        static private List<Book> books = new List<Book>
        {
            new Book { id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", YearPublished = 1925 },
            new Book { id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", YearPublished = 1960 },
            new Book { id = 3, Title = "1984", Author = "George Orwell", YearPublished = 1949 },
            new Book { id = 4,  Title = "Pride and Prejudice", Author = "Jane Austen", YearPublished = 1813 },
            new Book { id = 5, Title = "The Catcher in the Rye", Author = "J.D. Salinger", YearPublished = 1951 }
        };
        [HttpGet]
        public ActionResult <List<Book>> GetBooks()
        {
            return Ok(books);
        }
    }
}
