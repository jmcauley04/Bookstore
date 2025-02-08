namespace Bookstore.Models.Entities;

public class ProductInventory
{
    public int StoreId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime CreatedAt { get; set; }
}