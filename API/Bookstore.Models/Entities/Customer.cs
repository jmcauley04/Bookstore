namespace Bookstore.Models.Entities;

public class Customer
{
    public int CustomerID { get; set; }
    public string? Email { get; set; }
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public int? AddressID { get; set; }
    public Address? Address { get; set; }
}
