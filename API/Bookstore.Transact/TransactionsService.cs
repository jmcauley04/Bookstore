using Bookstore.Transact.Interfaces;
using Bookstore.Transact.Transactions;
using Bookstore.Transact.Transactions.Purchase;
using Bookstore.Transact.Transactions.StoreMerch;
using Transact.Models;

namespace Bookstore.Transact;

internal class TransactionsService(IBookstoreTransactRepository transactRepository) : ICreateTransactions
{
    public async Task<Transaction> AddStoreTransaction(IStorePurchaseTransaction purchase)
    {
        var transaction = new Transaction
        {
            Amount = purchase.Amount,
            Timestamp = DateTime.UtcNow,
            Type = TransactionType.Income,
            CategoryId = (int)TransactionCategory.StoreMerch,
            Comments = purchase.Comments
        };

        await transactRepository.AddTransactionAsync(transaction);
        
        var storeMerchTransaction = new StoreMerchTransaction
        {
            AssociateID = purchase.AssociateID,
            StoreID = purchase.StoreID,
            CustomerID = purchase.CustomerID,
            RegisterID = purchase.RegisterID,
            TransactionID = transaction.ID!.Value
        };
        
        await transactRepository.AddStoreMerchTransaction(storeMerchTransaction);

        var purchaseTransactions = purchase.Purchases.Select(p => new PurchaseTransaction
        {
            TransactionID = transaction.ID!.Value,
            ProductID = p.ProductID,
            Quantity = p.Quantity
        });

        await transactRepository.AddPurchaseTransactions(purchaseTransactions);

        return transaction;
    }
}
