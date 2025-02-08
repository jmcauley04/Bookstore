using Bookstore.Models.Interfaces;

namespace Bookstore.Register;

internal class RegisterFactory(IRegisterRepository registerRepository)
{
    public async Task<IRegister> GetRegister(int storeId, int registerId)
    {
        var register = await registerRepository.GetRegisterAsync(storeId, registerId);
        return new BookstoreRegister(register, registerRepository);
    }
}