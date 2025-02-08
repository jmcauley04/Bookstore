namespace Bookstore.Models.DTOs.Payment;

public class PaymentInfoDTO
{
    public PaymentMethodType PaymentMethod { get; set; }
}

public enum PaymentMethodType {
    Cash,
    Credit,
    Check,
    PayPal,
    GooglePay,
    ApplePay
}