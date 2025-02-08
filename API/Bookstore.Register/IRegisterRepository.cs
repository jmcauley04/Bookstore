namespace Bookstore.Register;
using Bookstore.Models.Entities;

public interface IRegisterRepository
{
    Task UpsertRegisterAsync(StoreRegister register);
    StoreRegister GetRegister(int storeId, int registerId);
    Task<StoreRegister> GetRegisterAsync(int storeId, int registerId);
}
