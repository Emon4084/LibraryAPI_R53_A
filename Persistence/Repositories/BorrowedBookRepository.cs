using LibraryAPI_R53_A.Core.Domain;
using LibraryAPI_R53_A.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI_R53_A.Persistence.Repositories
{
    public class BorrowedBookRepository : IBorrowBook
    {
        private readonly ApplicationDbContext _context;

        public BorrowedBookRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateBorrowBook(BorrowedBook borrowedBook)
        {
           _context.BorrowedBooks.Add(borrowedBook);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<BorrowedBook>> GetAllRequestedBooksByUserName(string userName)
        {
            return await _context.BorrowedBooks
                .Include(b => b.Book)
                .Include(b => b.BookCopy)
                .Where(b => b.UserInfo.UserName == userName && b.Status == "Requested")
                .ToListAsync();

        } 
        public async Task<IEnumerable<BorrowedBook>> GetAllCancelledBooksByUserName()
        {
            return await _context.BorrowedBooks
                .Include(b => b.Book)
                .Include(b => b.BookCopy)
                .Where(b => b.Status == "Cancelled")
                .ToListAsync();
        }

        public async Task<IEnumerable<BorrowedBook>> GetAll()
        {
            return await _context.BorrowedBooks
                .Include(b => b.Book)
                .Include(b => b.BookCopy)
                .ToListAsync();
        }

        public Task<BorrowedBook?> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BorrowedBook?> Post(BorrowedBook entity)
        {
            throw new NotImplementedException();
        }

        public Task Put(BorrowedBook entities)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BorrowedBook> Search(string searchString)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BorrowedBook> GetActive()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BorrowedBook> GetInactive()
        {
            throw new NotImplementedException();
        }
    }
}
