using System.Linq.Expressions;

namespace CRM01.Core
{
    public interface IRepository<T> where T : class
    {
        T Get(int Id);
        IEnumerable<T> GetAll();

        IEnumerable<T> Find(Expression<Func<T, bool>> prdicate);

        T SingleOrDefault(Expression<Func<T, bool>> predicate);

        void Add(T entity);

        void AddRange(T entities);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }

}
