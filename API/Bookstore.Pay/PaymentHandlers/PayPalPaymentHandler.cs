using Bookstore.Models.DTOs.Payment;
using Bookstore.Pay.Interfaces;

namespace Bookstore.Pay.PaymentHandlers;

internal class PayPalPaymentHandler : IPaymentHandler
{
    public async Task Process(IPaymentInfo payment)
    {
        await Task.Delay(1000);
        Console.WriteLine("PayPal payment processed");
        // need to call the paypal api
    }
}