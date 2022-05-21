using Domain.Interfaces.Security;

namespace Domain.Entitäten.Security;

public class User : Base, ICredentials
{
    public User() => Days = new List<Day>();

    public List<Day> Days         { get; set; }
    public string    PasswordSalt { get; set; }
    public string    EmailAddress { get; set; }
    public string    PasswordHash { get; set; }
}