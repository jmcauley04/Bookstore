using Bookstore.Pay.Interfaces;
using Microsoft.Extensions.Logging;

namespace Bookstore.Pay;

internal class PaymentService(
    ILogger<PaymentService> logger
) : IPaymentService
{
    public async Task ProcessPayment(IPaymentInfo paymentInfo){
        try{
            logger.LogInformation("Processing payment");
            var paymentHandler = PaymentHandlerFactory.GetPaymentHandler(paymentInfo.PaymentMethod);
            await paymentHandler.Process(paymentInfo);
        } catch (Exception e){
            logger.LogError(e, "Error processing payment");
            throw;
        }
    }
}
