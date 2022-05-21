namespace Domain.Entitäten;

public abstract class Base
{
    protected Base()
    {
        Id         = Guid.NewGuid();
        CreatedAt  = DateTime.Now;
        ModifiedAt = DateTime.Now;
    }

    public Guid     Id         { get; set; }
    public string   Name       { get; set; }
    public DateTime CreatedAt  { get; set; }
    public DateTime ModifiedAt { get; set; }
}