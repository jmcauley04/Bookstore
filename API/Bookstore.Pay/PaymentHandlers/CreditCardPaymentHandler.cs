using Bookstore.Models.DTOs.Payment;
using Bookstore.Pay.Interfaces;

namespace Bookstore.Pay.PaymentHandlers;

internal class CreditCardPaymentHandler : IPaymentHandler
{
    public async Task Process(IPaymentInfo payment)
    {
        await Task.Delay(1000);
        Console.WriteLine("Credit card payment processed");
        // need to call a cc processor service like stripe
    }
}