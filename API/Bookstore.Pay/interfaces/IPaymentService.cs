namespace Bookstore.Pay.Interfaces;

public interface IPaymentService
{
    Task ProcessPayment(IPaymentInfo paymentInfo);
}