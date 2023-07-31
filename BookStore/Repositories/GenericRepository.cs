using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace bookstore.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly DbContext context;
    private readonly DbSet<T> table;

    public GenericRepository(DbContext context)
    {
        this.context = context;
        this.table = context.Set<T>();
    }

    public T Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public T Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> Get(Expression expression)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public T GetOne(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<T> Save(T entity)
    {
        this.table.Add(entity);
        await this.context.SaveChangesAsync();
        return entity;
    }

    public T Update(T entity)
    {
        throw new NotImplementedException();
    }
}