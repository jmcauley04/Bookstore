using Bookstore.Models.DTOs.Payment;
using Bookstore.Pay.PaymentHandlers;

namespace Bookstore.Pay;

internal static class PaymentHandlerFactory
{
    public static IPaymentHandler GetPaymentHandler(PaymentMethodType paymentMethod)
    {
        return paymentMethod switch
        {
            PaymentMethodType.Cash => new CashPaymentHandler(),
            PaymentMethodType.Credit => new CreditCardPaymentHandler(),
            PaymentMethodType.PayPal => new PayPalPaymentHandler(),
            _ => throw new ArgumentException("Invalid payment method")
        };
    }
}