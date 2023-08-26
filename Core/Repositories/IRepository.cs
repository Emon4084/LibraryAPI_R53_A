using System.Linq.Expressions;

namespace LibraryAPI_R53_A.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> Get(int id);
        void Add(TEntity entity);
        void Update(TEntity entities);

        void Remove(TEntity entity);

        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);

        //void Save();

    }
}
