using Bookstore.Inventory.Interfaces;

namespace Bookstore.Inventory;

internal class InventoryService(
    BookstoreInventory bookmarkedInventory
) : IAdjustInventory
{
    public async Task UpdateInventory(IStoreInventoryAdjustment adjustment)
    {
        var storeId = adjustment.StoreID;
        var purchases = adjustment.Purchases;

        await bookmarkedInventory.AdjustInventory(storeId, purchases.Select(x => (x.ProductID, -x.Quantity)));
    }
}