using AutoMapper;
using LibraryAPI_R53_A.Core.Domain;
using LibraryAPI_R53_A.Core.Interfaces;
using LibraryAPI_R53_A.Core.Repositories;
using LibraryAPI_R53_A.Helpers;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI_R53_A.Persistence.Repositories
{
    public class BookRepository : IBook
    {
        private readonly ApplicationDbContext _context;
        

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _context.Books.ToListAsync();

        }

        public async Task<Book?> Get(int id)
        {
            var book = await _context.Books.FindAsync(id);
            return book;
        }


        public async Task<Book?> Post(Book entity)
        {
            if (_context.Books.Any(b => b.ISBN == entity.ISBN))
            {
                return null;
            }
            _context.Books.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Put(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
        }
        public IEnumerable<Book> Search(string searchString)
        {
            var book = from b in _context.Books
                            where b.Title.ToLower().Contains(searchString.ToLower())
                            select b;
            return book.ToList();
        }
        public IEnumerable<Book> GetActive()
        {
            var book = from b in _context.Books
                            where b.IsActive == true
                            select b;
            return book;
        }

        public IEnumerable<Book> GetInactive()
        {
            var book = from b in _context.Books
                            where b.IsActive == false
                            select b;
            return book;
        }

        public async Task<Book?> GetByISBN(string isbn)
        {
            return await _context.Books.FirstOrDefaultAsync(b => b.ISBN == isbn);
        }

    }
}
