using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meus_produtos.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Add(TEntity obj);
        Task<TEntity> Update(TEntity obj);
        Task<TEntity> Remove(TEntity obj);
        void Dispose();
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();

    }
}
