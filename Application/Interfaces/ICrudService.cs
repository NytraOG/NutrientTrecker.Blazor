namespace Application.Interfaces;

public interface ICrudService<TEntity, in TModel>
{
    public Task<IEnumerable<TEntity>> GetAllAsync();

    public Task<TEntity> GetAsync(Guid id);

    public Task<TEntity> CreateAsync(TModel model);

    public Task<TEntity> UpdateAsync(TModel model, Guid id);

    public Task DeleteAsync(Guid id);

    public Task SaveAsync();
}