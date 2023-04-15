using CRM01.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace CRM01.Persistence.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        // Here we are working with a DbContext, not PlutoContext. So we don't have DbSets 
        // such as Employee, and we need to use the generic Set() method to access them.
        protected DbContext dbContext;

        protected DbSet<T> entities;

        public Repository(DbContext dbcontext)
        {
            dbContext = dbcontext;
            entities = dbContext.Set<T>();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(T entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return entities.Where(predicate);
        }

        public T Get(int Id) 
        {
           var t = entities.Find(Id);

            if (t != null) return t;

            return null;

            
        }

        public IEnumerable<T> GetAll()
        {
          return entities.ToList(); 
        }

        public void Remove(T entity)
        {
            entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> _entities)
        {
            entities.RemoveRange(_entities);
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
          return entities.SingleOrDefault(predicate);
        }
    }
}
