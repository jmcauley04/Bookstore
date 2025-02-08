#nullable disable

namespace Bookstore.Models.Entities;

public class Address
{
    public int ID { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
}
