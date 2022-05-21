using Application.Interfaces;

namespace Application.Services;

public abstract class BaseCrudService<TEntity, TModel> : ICrudService<TEntity, TModel>
{
    protected readonly IApplicationDbContext Context;

    protected BaseCrudService(IApplicationDbContext context) => Context = context ?? throw new ArgumentNullException(nameof(context));

    public abstract Task<IEnumerable<TEntity>> GetAllAsync();

    public abstract Task<TEntity> GetAsync(Guid id);

    public Task<TEntity> CreateAsync(TModel model) => throw new NotImplementedException();

    public Task<TEntity> UpdateAsync(TModel model, Guid id) => throw new NotImplementedException();

    public Task DeleteAsync(Guid id) => throw new NotImplementedException();

    public Task SaveAsync() => throw new NotImplementedException();
}