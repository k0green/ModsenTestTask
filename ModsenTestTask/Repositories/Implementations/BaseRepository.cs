using Microsoft.EntityFrameworkCore;
using ModsenTestTask.Data;
using ModsenTestTask.Data.Entities;
using ModsenTestTask.Repositories.Interfaces;

namespace ModsenTestTask.Repositories.Implementations;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
{
    protected readonly ApplicationDbContext _dbContext;
    protected DbSet<T> _dbSet;

    protected BaseRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<T>();
    }

    public virtual async Task<T> GetByIdAsync(string id)
        => await _dbSet.FindAsync(id);

    public virtual async Task<List<T>> GetAllAsync() 
        => await _dbSet.ToListAsync();

    public virtual async Task AddAsync(T model)
    {
        await _dbSet.AddAsync(model);
        await _dbContext.SaveChangesAsync();
    }

    public virtual async Task UpdateAsync(T model)
    {
        _dbSet.Update(model);
        await _dbContext.SaveChangesAsync();
    }

    public virtual async Task DeleteAsync(T model)
    {
        _dbSet.Remove(model);
        await _dbContext.SaveChangesAsync();
    }

    public virtual async Task DeleteByIdAsync(string id)
    {
        await DeleteAsync(await GetByIdAsync(id));
        await _dbContext.SaveChangesAsync();
    }
}