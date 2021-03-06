using Meus_produtos.Application.Commons;
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

        protected Response Ok(object obj)
        {

            return new Response(200, obj);
        }

        protected Response BadRequest(object value)
        {
            return new Response(400, value);
        }

    }
}
