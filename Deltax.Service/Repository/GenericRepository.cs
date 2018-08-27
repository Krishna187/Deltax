using Deltax.Entity.Domain;
using Deltax.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Deltax.Service.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T:class
    {
        internal readonly CastingContext _dbContext;
        internal DbSet<T> _dbSet;
        public GenericRepository(CastingContext db)
        {
            _dbContext = db ;
            _dbSet = _dbContext .Set<T>();
        }
        public void Add(T entity)
        {
           _dbSet.Add(entity);
        }

        public void DeleteById (object id)
        {
            T entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Edit(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual IEnumerable<T> GetAll(
             Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "")
        {
            //IQueryable<T> query = _dbSet;

            //if (filter != null)
            //{
            //    query = query.Where(filter);
            //}

            //foreach (var includeProperty in includeProperties.Split
            //    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            //{
            //    query = query.Include(includeProperty);
            //}

            //if (orderBy != null)
            //{
            //    return orderBy(query).ToList();
            //}
            //else
            //{
            //    return query.ToList();
            //}
            return _dbSet.ToList();
        }

        public virtual T GetByID(object id)
        {
            return _dbSet.Find(id);
        }

        //public void Save()
        //{
        //    _dbContext.SaveChanges();
        //}

        //public Task<int> SaveAsync()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
