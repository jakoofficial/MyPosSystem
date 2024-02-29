using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MyPosSystem;
using MyPosSystem.Interfaces;

namespace MyPosSystem.Interfaces;

public abstract class ReposityBase<T> : IRepositoryBase<T> where T : class
{
    protected DBContext Context { get; set; }

    public ReposityBase(DBContext ctx)
    {
        Context = ctx;
    }

    public IQueryable<T> FindAll() => Context.Set<T>().AsNoTracking();

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
        Context.Set<T>().Where(expression).AsNoTracking();
    
    public void Create(T entity) => Context.Set<T>().Add(entity);
    public void Update(T entity) => Context.Set<T>().Update(entity);
    public void Delete(T entity) => Context.Set<T>().Remove(entity);
}