namespace Bookstore.Models.Interfaces;

public interface IRegister
{
    decimal Total { get; }
    decimal Cash { get; }
    decimal Credit { get; }
    decimal Check { get; }    
    Task AddCash(decimal amount);
    Task AddCredit(decimal amount);
    Task AddCheck(decimal amount);
    Task Clear();
}
