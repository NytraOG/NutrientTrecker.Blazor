namespace Application.Interfaces;

public interface ICrudService<TEntity, in TModel>
{
    Task<IEnumerable<TEntity>> GetAllAsync();

    Task<TEntity> GetAsync(Guid id);

    Task<TEntity> CreateAsync(TModel model);

    Task<TEntity> UpdateAsync(TModel model, Guid id);

    Task DeleteAsync(Guid id);

    Task SaveAsync();
}