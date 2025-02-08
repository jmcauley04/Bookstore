namespace Bookstore.Models.Entities;

public class StoreRegister
{
    public int StoreId { get; set; }
    public int RegisterId { get; set; }
    public decimal Cash { get; set; }
    public decimal Credit { get; set; }
    public decimal Check { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime CreatedAt { get; set; }    
}