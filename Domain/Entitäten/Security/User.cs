
using Domain.Interfaces.Security;

namespace Domain.Entitäten.Security;

public class User : BaseCrudObject, ICredentials
{
    public string EmailAddress { get; set; }
    public string Password     { get; set; }
}