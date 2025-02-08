using Bookstore.Transact.Transactions.Purchase;
using Bookstore.Transact.Transactions.StoreMerch;
using Transact;

namespace Bookstore.Transact;

public interface IBookstoreTransactRepository : ITransactRepository
{
    Task AddStoreMerchTransaction(StoreMerchTransaction transaction);
    Task AddPurchaseTransactions(IEnumerable<PurchaseTransaction> transaction);
}
