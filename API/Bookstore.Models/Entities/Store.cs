namespace Bookstore.Models.Entities;

public class Store
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int AddressID { get; set; }
    public Address Address { get; set; } = null!;

}
