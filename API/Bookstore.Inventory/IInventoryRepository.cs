namespace Bookstore.Inventory;
using Bookstore.Models.Entities;

public interface IInventoryRepository
{
    Task UpsertInventory(IEnumerable<ProductInventory> inventory);
    Task<ProductInventory> UpsertInventory(ProductInventory inventory);
    Task<ProductInventory> GetInventory(int storeId, int productId);
    Task<IEnumerable<ProductInventory>> GetInventory(int storeId);
}
