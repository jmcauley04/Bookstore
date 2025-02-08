namespace Bookstore.Inventory.Interfaces;

public interface IAdjustInventory
{
    Task UpdateInventory(IStoreInventoryAdjustment adjustment);
}
