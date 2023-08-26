using LibraryAPI_R53_A.Core.Domain;
using LibraryAPI_R53_A.Core.Repositories;
using System.Linq.Expressions;

namespace LibraryAPI_R53_A.Persistence.Repositories
{
    public class PublisherRepository : Repository<Publisher>
    {
        public PublisherRepository(LibraryDbContext context):base(context)
        {
            
        }

        public LibraryDbContext libraryContext => _context as LibraryDbContext;
        public void Add(Publisher publisher)
        {
            libraryContext.Publishers.Add(publisher);
            libraryContext.SaveChanges();
            
        }

        public Task<IEnumerable<Publisher>> Find(Expression<Func<Publisher, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Publisher> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Publisher>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Publisher entity)
        {
            throw new NotImplementedException();
        }

        

        public void Update(Publisher entities)
        {
            throw new NotImplementedException();
        }
    }
}
