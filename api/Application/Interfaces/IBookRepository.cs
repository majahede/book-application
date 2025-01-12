using BookApi.Models;

namespace BookApi.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book>? GetBookById(Guid id);
        Task CreateBook(Book book);
        Task UpdateBook(Book book, Book updatedBook);
        Task DeleteBook(Book book);
    }
}
