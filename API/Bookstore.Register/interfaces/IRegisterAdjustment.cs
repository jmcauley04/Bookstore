using Bookstore.Models.DTOs.Payment;

namespace Bookstore.Register.Interfaces;

public interface IRegisterAdjustment
{
    int StoreID { get; }
    int RegisterID { get; }
    PaymentMethodType PaymentMethod { get; }
    decimal Amount { get; }    
}