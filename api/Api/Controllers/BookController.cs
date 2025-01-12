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
        public async Task<ActionResult<IEnumerable<Book>>> GetAll()
        {
            var books = await _bookService.GetAllBooks();
            return Ok(books);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Book>> GetById(Guid id)
        {
            var book = await _bookService.GetBookById(id);

            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Book book)
        {
            var id = await _bookService.CreateBook(book);

            return Ok(id);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] Book book)
        {
            var updatedBook = await _bookService.UpdateBook(id, book);

            return Ok(updatedBook);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _bookService.DeleteBook(id);

            return Ok("Book was deleted successfully");
        }
    }
}
