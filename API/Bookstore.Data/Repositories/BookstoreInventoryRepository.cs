using Bookstore.Inventory;
using Bookstore.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data.Repositories;

public class BookstoreInventoryRepository(BookstoreDbContext dbContext) : BookstoreRepository(dbContext), IInventoryRepository
{
    public async Task<ProductInventory> GetInventory(int storeId, int productId)
    {
        var now = DateTime.UtcNow;
        return await _dbContext.Inventory.SingleOrDefaultAsync(i => i.StoreId == storeId && i.ProductId == productId) ?? new ProductInventory
        {
            StoreId = storeId,
            ProductId = productId,
            Quantity = 0,
            UpdatedAt = now,
            CreatedAt = now
        };
    }

    public async Task<IEnumerable<ProductInventory>> GetInventory(int storeId)
    {
        return await _dbContext.Inventory.Where(i => i.StoreId == storeId).ToListAsync();
    }

    public Task UpsertInventory(IEnumerable<ProductInventory> inventory)
    {
        var storeIds = inventory.Select(i => i.StoreId).Distinct();
        foreach (var storeId in storeIds)
        {
            var existingInventory = _dbContext.Inventory.Where(i => i.StoreId == storeId).ToList();
            foreach (var inv in inventory.Where(i => i.StoreId == storeId))
            {
                var existing = existingInventory.SingleOrDefault(i => i.ProductId == inv.ProductId);
                if (existing is not null)
                {
                    existing.Quantity = inv.Quantity;
                    existing.UpdatedAt = DateTime.UtcNow;
                }
                else
                {
                    inv.CreatedAt = inv.UpdatedAt = DateTime.UtcNow;
                    _dbContext.Inventory.Add(inv);
                }
            }
        }
        return _dbContext.SaveChangesAsync();
    }

    public Task<ProductInventory> UpsertInventory(ProductInventory inventory)
    {
        var existing = _dbContext.Inventory.SingleOrDefault(i => i.StoreId == inventory.StoreId && i.ProductId == inventory.ProductId);
        if (existing is not null)
        {
            existing.Quantity = inventory.Quantity;
            existing.UpdatedAt = DateTime.UtcNow;
        }
        else
        {
            inventory.CreatedAt = inventory.UpdatedAt = DateTime.UtcNow;
            _dbContext.Inventory.Add(inventory);
        }
        return _dbContext.SaveChangesAsync().ContinueWith(_ => inventory);
    }
}
