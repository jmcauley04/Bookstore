using Bookstore.Models.DTOs.Payment;
using Bookstore.Pay.Interfaces;

namespace Bookstore.Pay;

internal interface IPaymentHandler
{
    Task Process(IPaymentInfo payment);
}