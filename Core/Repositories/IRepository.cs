using System.Linq.Expressions;

namespace LibraryAPI_R53_A.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity?> Get(int id);
        Task<TEntity?> Post(TEntity entity);
        Task<TEntity?> Put(int id, TEntity entity);
        Task<TEntity?> Delete(int id);


    }
}
