using Bookstore.Pay.Interfaces;

namespace Bookstore.Pay.PaymentHandlers;

internal class CashPaymentHandler : IPaymentHandler
{
    public async Task Process(IPaymentInfo payment)
    {
        await Task.Delay(1000);
        Console.WriteLine("Cash payment processed");
        // need to make a log to the register
    }
}