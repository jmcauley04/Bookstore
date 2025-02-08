using Bookstore.Models.DTOs.Payment;

namespace Bookstore.Pay.Interfaces;

public interface IPaymentInfo
{
    PaymentMethodType PaymentMethod { get; }
}