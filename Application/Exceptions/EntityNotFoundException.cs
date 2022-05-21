namespace Application.Exceptions;

public class EntityNotFoundException<T> : Exception
{
    public EntityNotFoundException(Guid id) : base($"Entity {nameof(T)} not found by Id '{id}'") { }
}