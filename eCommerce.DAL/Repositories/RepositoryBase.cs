using eCommerce.DAL.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.Repositories
{
     public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity: class
    {
        internal DataContext context;
        internal DbSet<TEntity> dbset;

        public RepositoryBase(DataContext context)
        {
            this.context = context;
            this.dbset = context.Set<TEntity>();
        }

        public virtual TEntity GetById(object id)
        {
            return dbset.Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return dbset;
        }

        public IQueryable<TEntity> GetPaged(int top = 20, int skip = 0, object orderBy = null, object filter = null)
        {
            return null; // need to override in order to implement specific filtering and ordering
        }

        public IQueryable<TEntity> GetAll(object filter)
        {
            return null; // need to override in order to implement specific filtering
        }

        public virtual TEntity GetFullObject(object id)
        {
            return null;
        }

        public virtual void Insert(TEntity entity)
        {
            dbset.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            dbset.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
                dbset.Attach(entity);

            dbset.Remove(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entity = dbset.Find(id);
            Delete(entity);
        }

        public virtual void Dispose()
        {
            context.Dispose();
        }
    }
}
