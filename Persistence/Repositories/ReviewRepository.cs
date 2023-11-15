using LibraryAPI_R53_A.Core.Domain;
using LibraryAPI_R53_A.Core.Interfaces;

namespace LibraryAPI_R53_A.Persistence.Repositories
{
    public class ReviewRepository : IBookReview
    {
        private readonly ApplicationDbContext _context;

        public ReviewRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<BookReview?> Post(BookReview entity)
        {
            _context.BookReviews.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public Task Put(BookReview entities)
        {
            throw new NotImplementedException();
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BookReview?> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookReview> GetActive()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BookReview>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookReview> GetInactive()
        {
            throw new NotImplementedException();
        }



        public IEnumerable<BookReview> Search(string searchString)
        {
            throw new NotImplementedException();
        }
    }
}
