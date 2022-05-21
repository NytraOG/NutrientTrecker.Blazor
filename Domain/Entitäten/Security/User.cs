using Domain.Interfaces.Security;

namespace Domain.Entitäten.Security;

public class User : Base, ICredentials
{
    public User() => Days = new List<Day>();

    public string    Salt         { get; set; }
    public List<Day> Days         { get; set; }
    public string    EmailAddress { get; set; }
    public string    Password     { get; set; }
}