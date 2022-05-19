namespace Domain.Interfaces.Security;

public interface ICredentials
{
    public string EmailAddress { get; set; }
    public string Password     { get; set; }
}