using Bookstore.Inventory.Interfaces;
using Bookstore.Models.DTOs.Payment;
using Bookstore.Models.DTOs.StoreMerch;
using Bookstore.Models.Entities;
using Bookstore.Pay.Interfaces;
using Bookstore.Register.Interfaces;
using Bookstore.Transact.Interfaces;

namespace Bookstore.API.Adapters;

public class StorePurchaseAdapter(PurchaseStoreMerchDTO purchaseStoreMerchDTO) : 
    IStorePurchaseTransaction, 
    IStoreInventoryAdjustment, 
    IRegisterAdjustment,
    IPaymentInfo
{
    public decimal Amount => purchaseStoreMerchDTO.CreateStoreMerchTransactionDTO.Amount;
    public string? Comments => purchaseStoreMerchDTO.CreateStoreMerchTransactionDTO.Comments;
    public int AssociateID => purchaseStoreMerchDTO.CreateStoreMerchTransactionDTO.AssociateID;
    public int StoreID => purchaseStoreMerchDTO.CreateStoreMerchTransactionDTO.StoreID;
    public int RegisterID => purchaseStoreMerchDTO.CreateStoreMerchTransactionDTO.RegisterID;
    public int CustomerID => purchaseStoreMerchDTO.CreateStoreMerchTransactionDTO.CustomerID;
    public IEnumerable<Purchase> Purchases => purchaseStoreMerchDTO.Purchases;
    public PaymentMethodType PaymentMethod => purchaseStoreMerchDTO.PaymentInfoDTO.PaymentMethod;
}