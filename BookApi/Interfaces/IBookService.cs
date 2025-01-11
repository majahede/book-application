using BookApi.Models;

namespace BookApi.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooks();
    }
}
