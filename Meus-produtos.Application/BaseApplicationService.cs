using Meus_produtos.Application.Interfaces;
using Meus_produtos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meus_produtos.Application
{
    public class BaseApplicationService<TEntity> : IDisposable, IBaseApplicationService<TEntity> where TEntity : class
    {

        private readonly IBaseService<TEntity> baseServiceApplication;
        public BaseApplicationService(IBaseService<TEntity> baseServiceApplication)
        {
            this.baseServiceApplication = baseServiceApplication;
        }

        public void Add(TEntity obj)
        {
            baseServiceApplication.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return baseServiceApplication.GetAll();
        }

        public TEntity GetById(int id)
        {
            return baseServiceApplication.GetById(id);

        }

        public void Remove(TEntity obj)
        {
            baseServiceApplication.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            baseServiceApplication.Update(obj);
        }

        public void Dispose()
        {
            baseServiceApplication.Dispose();
        }

    }
}
