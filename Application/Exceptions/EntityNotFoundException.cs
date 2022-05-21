namespace Application.Exceptions;

public class EntityNotFoundException<T> : Exception
{
    public EntityNotFoundException(Guid id) : base($"Entity {typeof(T).Name} not found by Id '{id}'") { }
}