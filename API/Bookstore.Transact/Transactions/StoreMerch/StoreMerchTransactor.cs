using Transact;
using Transact.Models;

namespace Bookstore.Transact.Transactions.StoreMerch;

public class StoreMerchTransactor(Transaction transaction, StoreMerchTransaction storeMerchTransaction, IBookstoreTransactRepository db) : ITransactor
{
    public Transaction Transaction => transaction;
    public StoreMerchTransaction StoreMerchTransaction => storeMerchTransaction;

    public async Task ProcessTransactionAsync()
    {
        await db.UsingTransaction(async () =>
        {
            // save base transaction to global transaction log
            await db.AddTransactionAsync(transaction);

            storeMerchTransaction.TransactionID = transaction.ID!.Value;
            // save data to store merch log
            await db.AddStoreMerchTransaction(storeMerchTransaction);
        });
    }
}
