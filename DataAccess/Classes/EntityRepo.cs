using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using DataAccess.Interfaces;
using Entities.Context;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Classes;

public class EntityRepo<T> : IEntityRepo<T>
where T : class, new()
{
    private readonly NorthwindEfCoreContext _context;
    private readonly DbSet<T> _dbSet;

    public EntityRepo(NorthwindEfCoreContext p_context)
        => _dbSet = (_context = p_context).Set<
    T>();

    public IQueryable<T> GetAll() =>   _dbSet.AsNoTracking();

    public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        => _dbSet.AsNoTracking().Where(predicate);

    public async Task<T> GetByIdAsync(int id) =>
        await _dbSet.FindAsync(id);


    public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate) =>
        await _dbSet.AnyAsync(predicate);

    private async Task CUD(T entity, EntityState state)
    {
        _context.Entry(entity).State = state;
        await _context.SaveChangesAsync();
        _context.Entry(entity).State = EntityState.Detached;
    }

    public async Task AddAsync(T entity) =>

        await CUD(entity, EntityState.Added);


    public async Task AddRangeAsync(IQueryable<T> entities)
    {
        foreach (var x in entities) await AddAsync(x);
    }

    public async Task Update(T entity) =>

        await CUD(entity, EntityState.Modified);

    public async Task Remove(T entity) =>
        await CUD(entity, EntityState.Deleted);

    public async Task RemoveRange(IQueryable<T> entities) =>
        entities.ToList().ForEach(async x => await Remove(x));
    //=> await entities.ForEachAsync(async x => await Remove(x));

}

