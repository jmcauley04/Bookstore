#nullable disable
namespace Bookstore.Models.Entities;

public class Associate
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Address Address { get; set; } = null!;
}
