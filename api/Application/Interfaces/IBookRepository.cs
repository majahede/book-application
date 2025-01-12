using BookApi.Application.Dtos;
using BookApi.Domain.Models;

namespace BookApi.Application.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book>? GetBookById(Guid id);
        Task CreateBook(Book book);
        Task UpdateBook(Book book, BookDto updatedBook);
        Task DeleteBook(Book book);
    }
}
