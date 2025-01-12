using BookApi.Models;

namespace BookApi.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBookById(Guid id);
        Task<Guid> CreateBook(Book book);
        Task<Book> UpdateBook(Guid id, Book updatedBook);
        Task DeleteBook(Guid id);
    }
}
