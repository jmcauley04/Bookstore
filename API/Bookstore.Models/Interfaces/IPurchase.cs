using Bookstore.Models.DTOs.Payment;
using Bookstore.Models.Entities;

namespace Bookstore.Models.Interfaces;

public interface IPurchase
{
    PaymentInfoDTO PaymentInfoDTO { get; }
    List<Purchase> Purchases { get; }
}