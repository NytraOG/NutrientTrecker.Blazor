namespace Domain.Entitäten;

public abstract class BaseCrudObject
{
    protected BaseCrudObject()
    {
        Id         = Guid.NewGuid();
        CreatedAt  = DateTime.Now;
        ModifiedAt = DateTime.Now;
    }

    protected Guid     Id         { get; set; }
    protected string   Name       { get; set; }
    protected DateTime CreatedAt  { get; set; }
    protected DateTime ModifiedAt { get; set; }
}