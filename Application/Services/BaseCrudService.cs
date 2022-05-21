using Application.Interfaces;

namespace Application.Services;

public class BaseCrudService<TEntity, TModel> : ICrudService<TEntity, TModel>
{
    private readonly IApplicationDbContext context;

    protected BaseCrudService(IApplicationDbContext context) => this.context = context;

    public Task<IEnumerable<TEntity>> GetAllAsync() => throw new NotImplementedException();

    public Task<TEntity> GetAsync(Guid id) => throw new NotImplementedException();

    public Task<TEntity> CreateAsync(TModel model) => throw new NotImplementedException();

    public Task<TEntity> UpdateAsync(TModel model, Guid id) => throw new NotImplementedException();

    public Task DeleteAsync(Guid id) => throw new NotImplementedException();

    public Task SaveAsync() => throw new NotImplementedException();
}