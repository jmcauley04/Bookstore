using Transact.Models;

namespace Transact;

public class Transactor(ITransactRepository db, Transaction transaction) : ITransactor
{
    private readonly ITransactRepository _db = db;
    private readonly Transaction _transaction = transaction;
    public Transaction Transaction => _transaction;

    public async Task ProcessTransactionAsync()
    {
        await _db.AddTransactionAsync(_transaction);
    }
}
