using Bookstore.Models.Entities;

namespace Bookstore.Inventory.Interfaces
{
    public interface IStoreInventoryAdjustment
    {
        int StoreID { get; }
        IEnumerable<Purchase> Purchases { get; }
    }
}