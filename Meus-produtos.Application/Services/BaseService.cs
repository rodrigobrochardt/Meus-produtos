using Meus_produtos.Application.Interfaces;
using Meus_produtos.Domain.Interfaces.Repositories;

namespace Meus_produtos.Application.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {

        private readonly IBaseRepository<TEntity> baseRepository;
        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        
    }
}
