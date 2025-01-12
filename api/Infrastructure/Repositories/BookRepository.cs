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
        public async Task<Book>? GetBookById(Guid id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task CreateBook(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBook(Book book, Book updatedBook)
        {
            book.Title = updatedBook.Title;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBook(Book book)
        {
            _context.Books.Remove(book);

            await _context.SaveChangesAsync();
        }
    }
}
