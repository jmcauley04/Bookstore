using Transact.Models;

namespace Transact;

public interface ITransactor
{
    public Transaction Transaction { get; }
    Task ProcessTransactionAsync();
}
