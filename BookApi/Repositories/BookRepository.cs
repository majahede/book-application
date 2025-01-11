using BookApi.Context;
using BookApi.Interfaces;
using BookApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;
        public BookRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _context.Books.ToListAsync();
        }
    }
}
