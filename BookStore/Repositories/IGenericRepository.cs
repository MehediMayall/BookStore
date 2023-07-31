using System.Linq.Expressions;

namespace bookstore.Repositories;

public interface IGenericRepository<T> where T : class
{
    T GetOne(int id);
    IQueryable<T> Get(Expression expression);
    IQueryable<T> GetAll();
    T Update(T entity);
    Task<T> Save(T entity);
    T Delete(T entity);
    T Delete(int id);

}