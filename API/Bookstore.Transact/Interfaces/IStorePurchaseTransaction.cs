using Bookstore.Models.Entities;
using Bookstore.Transact.Transactions;
using Transact.Models;

namespace Bookstore.Transact.Interfaces;

public interface IStorePurchaseTransaction
{
    decimal Amount { get; }
    string? Comments { get; }
    int AssociateID { get; }
    int StoreID { get; }
    int RegisterID { get; }
    int CustomerID { get; }
    IEnumerable<Purchase> Purchases { get; }
}