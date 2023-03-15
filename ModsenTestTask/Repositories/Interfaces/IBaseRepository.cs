using ModsenTestTask.Data.Entities;

namespace ModsenTestTask.Repositories.Interfaces;

public interface IBaseRepository<T> where T : BaseModel
{
    public Task<T> GetByIdAsync(string id);

    public Task<List<T>> GetAllAsync();

    public Task AddAsync(T model);

    public Task UpdateAsync(T model);

    public Task DeleteAsync(T model);

    public Task DeleteByIdAsync(string id);
}