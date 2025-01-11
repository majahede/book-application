using BookApi.Models;

namespace BookApi.Interfaces
{
    public interface IBookService
    {
        Task<string> CreateBook(Book book);
        Task DeleteBook(Guid id);
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBookById(Guid id);
        Task<Book> UpdateBook(Guid id, Book book);
    }
}
