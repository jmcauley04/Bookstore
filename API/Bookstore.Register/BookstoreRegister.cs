namespace Bookstore.Register;
using Bookstore.Models.Entities;
using Bookstore.Models.Interfaces;

public class BookstoreRegister : IRegister
{
    private readonly IRegisterRepository _registerRepository;
    private StoreRegister _register;

    public BookstoreRegister(StoreRegister register, IRegisterRepository registerRepository)
    {
        _register = register;
        _registerRepository = registerRepository;
    }

    public decimal Total => _register.Cash + _register.Credit + _register.Check;
    public decimal Cash => _register.Cash;
    public decimal Credit => _register.Credit;
    public decimal Check => _register.Check;

    public async Task AddCash(decimal amount)
    {

        _register.Cash += amount;
        await _registerRepository.UpsertRegisterAsync(_register);
    }

    public async Task AddCheck(decimal amount)
    {
        _register.Check += amount;
        await _registerRepository.UpsertRegisterAsync(_register);
    }

    public async Task AddCredit(decimal amount)
    {
        _register.Credit += amount;
        await _registerRepository.UpsertRegisterAsync(_register);
    }

    public async Task Clear()
    {
        _register.Cash = 0;
        _register.Credit = 0;
        _register.Check = 0;
        await _registerRepository.UpsertRegisterAsync(_register);
    }
}