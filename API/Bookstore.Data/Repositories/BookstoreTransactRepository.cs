using Bookstore.Transact;
using Bookstore.Transact.Transactions.Purchase;
using Bookstore.Transact.Transactions.StoreMerch;
using Microsoft.EntityFrameworkCore;
using Transact.Models;

namespace Bookstore.Data.Repositories;

public class BookstoreTransactRepository(BookstoreDbContext dbContext) : BookstoreRepository(dbContext), IBookstoreTransactRepository
{
    public async Task AddPurchaseTransactions(IEnumerable<PurchaseTransaction> transactions)
    {
        _dbContext.PurchaseTransactions.AddRange(transactions);
        await _dbContext.SaveChangesAsync();
    }

    public async Task AddStoreMerchTransaction(StoreMerchTransaction transaction)
    {
        _dbContext.StoreMerchTransactions.Add(transaction);
        await _dbContext.SaveChangesAsync();
    }

    public async Task AddTransactionAsync(Transaction transaction)
    {
        _dbContext.Transactions.Add(transaction);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<Transaction>> GetTransactionsAsync(DateTime startDate, DateTime endDate)
    {
        return await _dbContext.Transactions
            .Where(t => t.Timestamp >= startDate.ToUniversalTime() && t.Timestamp <= endDate.ToUniversalTime())
            .ToListAsync();
    }
}
