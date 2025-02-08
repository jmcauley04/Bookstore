using Bookstore.Models.Entities;

namespace Bookstore.Transact.Transactions.StoreMerch;

public class StoreMerchTransaction
{
    public int? ID { get; set; }
    public int TransactionID { get; set; }
    public int AssociateID { get; set; }
    public int StoreID { get; set; }
    public int RegisterID { get; set; }
    public int CustomerID { get; set; }
}
