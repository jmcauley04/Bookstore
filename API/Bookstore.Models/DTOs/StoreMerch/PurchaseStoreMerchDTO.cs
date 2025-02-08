using Bookstore.Models.DTOs.Payment;
using Bookstore.Models.Entities;
using Bookstore.Models.Interfaces;

namespace Bookstore.Models.DTOs.StoreMerch;

public class PurchaseStoreMerchDTO : IPurchase
{
    public required CreateStoreMerchTransactionDTO CreateStoreMerchTransactionDTO { get; set; }
    public required PaymentInfoDTO PaymentInfoDTO { get; set; }
    public List<Purchase> Purchases { get; set; } = [];
}