namespace Bookstore.Models.DTOs.StoreMerch;

public class CreateStoreMerchTransactionDTO
{
    public int AssociateID { get; set; }
    public int StoreID { get; set; }
    public int RegisterID { get; set; }
    public int CustomerID { get; set; }
    public decimal Amount { get; set; }
    public string? Comments { get; set; }
}
