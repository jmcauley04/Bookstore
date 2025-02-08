namespace Bookstore.Models.Entities;

public class Product
{
    public int Id { get; set; }
    public required string UPC { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required ProductCategory Category { get; set; }
    public decimal Price { get; set; }
}

public enum ProductCategory {
    Book,
    Boardgame,
    Clothing,
    Misc,
    Food,
}
