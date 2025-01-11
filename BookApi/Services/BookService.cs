using BookApi.Interfaces;
using BookApi.Models;

namespace BookApi.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _bookRepository.GetAllBooks();
        }
    }
}
