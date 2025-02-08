using Transact;
using Transact.Models;

namespace Bookstore.Transact.Transactions.Purchase;

public class PurchaseTransactor(Transaction transaction, PurchaseTransaction purchaseTransaction, IBookstoreTransactRepository db) : ITransactor
{
    public Transaction Transaction => transaction;
    public PurchaseTransaction PurchaseTransaction => purchaseTransaction;

    public async Task ProcessTransactionAsync()
    {
        await db.UsingTransaction(async () =>
        {
            // save base transaction to global transaction log
            await db.AddTransactionAsync(transaction);

            purchaseTransaction.TransactionID = transaction.ID!.Value;
            // save data to store merch log
            // await db.AddPurchaseTransactions(purchaseTransaction);
        });
    }
}
