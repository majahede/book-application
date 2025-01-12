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

        public async Task<Book> GetBookById(Guid id)
        {
            var book = await _bookRepository.GetBookById(id) ?? throw new Exception("book does not exist");
            return book;
        }


        public async Task<Guid> CreateBook(Book book)
        {
            var id = Guid.NewGuid();

            book.Id = id;

            await _bookRepository.CreateBook(book);

            return id;
        }


        public async Task<Book> UpdateBook(Guid id, Book updatedBook)
        {
            var book = await GetBookById(id);

            await _bookRepository.UpdateBook(book, updatedBook);

            return book;
        }

        public async Task DeleteBook(Guid id)
        {
            var book = await GetBookById(id);
            await _bookRepository.DeleteBook(book);
        }
    }
}
