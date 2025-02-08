namespace Bookstore.Transact.Transactions.Purchase;

public class PurchaseTransaction
{
    public int? ID { get; set; }
    public int TransactionID { get; set; }
    public int ProductID { get; set; }
    public int Quantity { get; set; }
}
