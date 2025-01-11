using BookApi.Models;

namespace BookApi.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();
    }
}
