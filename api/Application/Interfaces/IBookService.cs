using BookApi.Application.Dtos;
using BookApi.Domain.Models;

namespace BookApi.Application.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBookById(Guid id);
        Task<Guid> CreateBook(BookDto book);
        Task<Book> UpdateBook(Guid id, BookDto updatedBook);
        Task DeleteBook(Guid id);
    }
}
