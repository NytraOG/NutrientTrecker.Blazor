namespace Domain.Interfaces;

public interface IConnectionAdapter
{
    public bool ConnectionIsOpen { get; }

    public void OpenConnection();

    public void CloseConnection();

    public void Save();
}