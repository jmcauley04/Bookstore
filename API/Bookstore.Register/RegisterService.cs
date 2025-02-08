using Bookstore.Models.DTOs.Payment;
using Bookstore.Models.DTOs.StoreMerch;
using Bookstore.Register.Interfaces;

namespace Bookstore.Register;

internal class RegisterService(
    RegisterFactory registerFactory
) : IUpdateRegister
{
    public async Task UpdateRegister(IRegisterAdjustment update)
    {
        var register = await registerFactory.GetRegister(update.StoreID, update.RegisterID);

        switch(update.PaymentMethod)
        {
            case PaymentMethodType.Cash:
                await register.AddCash(update.Amount);
                break;
            case PaymentMethodType.Check:
                await register.AddCheck(update.Amount);
                break;
            case PaymentMethodType.Credit:
                await register.AddCredit(update.Amount);
                break;
        }
    }
}