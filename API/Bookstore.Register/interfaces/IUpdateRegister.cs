namespace Bookstore.Register.Interfaces;

public interface IUpdateRegister
{
    Task UpdateRegister(IRegisterAdjustment update);
}