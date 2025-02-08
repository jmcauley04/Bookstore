using Bookstore.API.Adapters;
using Bookstore.Inventory.Interfaces;
using Bookstore.Models.DTOs.StoreMerch;
using Bookstore.Pay.Interfaces;
using Bookstore.Register.Interfaces;
using Bookstore.Transact.Interfaces;

namespace Bookstore.API.Services;

public class ProcessPurchaseService(
    ICreateTransactions transactionsService,
    IPaymentService paymentService,
    IUpdateRegister registerService,
    IAdjustInventory inventoryService
)
{
    public async Task ProcessStorePurchasePurchase(PurchaseStoreMerchDTO purchase)
    {
        var adaptedStorePurchase = new StorePurchaseAdapter(purchase);

        await paymentService.ProcessPayment(adaptedStorePurchase);
        await registerService.UpdateRegister(adaptedStorePurchase);
        await inventoryService.UpdateInventory(adaptedStorePurchase);
        await transactionsService.AddStoreTransaction(adaptedStorePurchase);
        
    }
}