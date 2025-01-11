using BookApi.Interfaces;
using BookApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
           _bookService = bookService;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _bookService.GetAllBooks();
        }
    }
}
