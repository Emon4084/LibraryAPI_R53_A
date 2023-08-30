using LibraryAPI_R53_A.Core.Domain;
using LibraryAPI_R53_A.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LibraryAPI_R53_A.Persistence.Repositories
{
    public class PublisherRepository : IPublisher
    {
        private readonly ApplicationDbContext _context;

        public PublisherRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Publisher>> GetAll()
        {
            return await _context.Publishers.ToListAsync();
        }

        public async Task<Publisher?> Get(int id)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            return publisher;
        }

        public async Task<Publisher?> Post(Publisher entity)
        {
            if (_context.Publishers.Any(p => p.PublisherName == entity.PublisherName))
            {
                return null;
            }
            _context.Publishers.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Publisher?> Put(int id, Publisher publisher)
        {
            var existingPublisher = await _context.Publishers.FindAsync(id);

            if (existingPublisher == null)
            {
                return null;
            }

            //can use automapper here
            existingPublisher.PublisherName = publisher.PublisherName;
            existingPublisher.Address = publisher.Address;
            existingPublisher.Email = publisher.Email;
            existingPublisher.PhoneNumber = publisher.PhoneNumber;
            existingPublisher.IsActive = publisher.IsActive;

            _context.Publishers.Update(existingPublisher);
            await _context.SaveChangesAsync();

            return existingPublisher;
        }
        
    
        public async Task<Publisher?> Delete(int id)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            if (publisher != null)
            {
                _context.Publishers.Remove(publisher);
                await _context.SaveChangesAsync();
                return publisher;
            }
            return null;
        }

      
    }
}
