using Bookstore.Models.Entities;

namespace Bookstore.Inventory;

internal class BookstoreInventory(IInventoryRepository inventoryRepository)
{
    private readonly IInventoryRepository _inventoryRepository = inventoryRepository;

    public async Task AdjustInventory(int storeId, IEnumerable<(int productId, int quantity)> adjustments)
    {
        var inventory = (await _inventoryRepository.GetInventory(storeId)).ToDictionary(inv => inv.ProductId);
        var changedInventory = new List<ProductInventory>();

        foreach (var adjustment in adjustments)
        {
            if (inventory.TryGetValue(adjustment.productId, out var inv))
            {
                inv.Quantity += adjustment.quantity;
                changedInventory.Add(inv);
            }
            else
            {
                changedInventory.Add(new ProductInventory
                {
                    ProductId = adjustment.productId,
                    StoreId = storeId,
                    Quantity = adjustment.quantity
                });
            }
        }

        await _inventoryRepository.UpsertInventory(changedInventory);
    }

    public async Task<ProductInventory> AdjustInventory(int storeId, int productId, int quantity)
    {
        var invOrNull = await _inventoryRepository.GetInventory(storeId, productId);
        if (invOrNull is null)
        {
            return await _inventoryRepository.UpsertInventory(new ProductInventory
            {
                ProductId = productId,
                StoreId = storeId,
                Quantity = quantity
            });
        }
        else
        {
            invOrNull.Quantity += quantity;
            return await _inventoryRepository.UpsertInventory(invOrNull);
        }
    }

    public async Task<IEnumerable<ProductInventory>> GetInventory(int storeId)
    {
        return await _inventoryRepository.GetInventory(storeId);
    }
}