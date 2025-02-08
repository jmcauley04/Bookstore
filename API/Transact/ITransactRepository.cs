using Transact.Models;

namespace Transact;

public interface ITransactRepository
{
    Task UsingTransaction(Func<Task> task);
    Task AddTransactionAsync(Transaction transaction);
    Task<IEnumerable<Transaction>> GetTransactionsAsync(DateTime startDate, DateTime endDate);
}
