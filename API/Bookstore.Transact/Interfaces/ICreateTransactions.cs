using Transact.Models;

namespace Bookstore.Transact.Interfaces;

public interface ICreateTransactions
{
    Task<Transaction> AddStoreTransaction(IStorePurchaseTransaction purchase);
}
