using Application.Interfaces;

namespace Application.Services;

public abstract class BaseCrudService<TEntity, TModel> : ICrudService<TEntity, TModel>
{
    protected readonly IApplicationDbContext Context;

    protected BaseCrudService(IApplicationDbContext context) => Context = context ?? throw new ArgumentNullException(nameof(context));

    public abstract Task<IEnumerable<TEntity>> GetAllAsync();

    public abstract Task<TEntity> GetAsync(Guid id);

    public abstract Task<TEntity> CreateAsync(TModel model);

    public abstract Task<TEntity> UpdateAsync(TModel model, Guid id);

    public abstract Task DeleteAsync(Guid id);

    public abstract Task SaveAsync();
}