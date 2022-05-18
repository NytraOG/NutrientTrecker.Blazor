namespace Domain.Interfaces;

public interface ICrudService<out TEntity, in TModel>
{
    public IEnumerable<TEntity> GetAll();

    public TEntity Get(Guid id);

    public TEntity Create(TModel model);

    public TEntity Update(TModel model, Guid id);

    public void Delete(Guid id);

    public void Save();
} 