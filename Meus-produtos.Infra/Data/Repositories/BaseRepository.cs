using Meus_produtos.Domain.Interfaces.Repositories;
using Meus_produtos.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meus_produtos.Infra.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected MySqlContext Db = new MySqlContext();

        public async Task<TEntity> Add(TEntity obj)
        {
            try
            {
                Db.Set<TEntity>().Add(obj);
                await Db.SaveChangesAsync();
                return obj;
            }
            catch (Exception except)
            {

                throw except.InnerException;
            }

        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            try
            {
                return  Db.Set<TEntity>().AsNoTracking().ToList();

            }
            catch (Exception except)
            {

                throw except.InnerException;

            }

        }

        public async Task<TEntity> GetById(int id)
        {
            try
            {
                var entity = Db.Set<TEntity>().Find(id);
                if(entity != null)
                {
                    Db.Entry(entity).State = EntityState.Detached;

                }
                return entity;

            }
            catch (Exception except)
            {

                throw except.InnerException;

            }
        }

        public async Task<TEntity> Remove(TEntity obj)
        {
            try
            {
                Db.Set<TEntity>().Remove(obj);
                await Db.SaveChangesAsync();
                return obj;
            }
            catch (Exception except)
            {

                throw except.InnerException;

            }


        }

        public async Task<TEntity> Update(TEntity obj)
        {
            try
            {
                Db.Entry(obj).State = EntityState.Modified;
                await Db.SaveChangesAsync();
                return obj;
            }
            catch (Exception except)
            {

                throw except.InnerException;

            }

        }
        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
