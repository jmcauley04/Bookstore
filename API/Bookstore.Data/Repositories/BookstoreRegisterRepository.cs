using Bookstore.Models.Entities;
using Bookstore.Register;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data.Repositories;

public class BookstoreRegisterRepository(BookstoreDbContext dbContext) : BookstoreRepository(dbContext), IRegisterRepository
{
    private StoreRegister GetNewStoreRegister(int storeId, int registerId)
    {
        return new()
        {
            StoreId = storeId,
            RegisterId = registerId,
            CreatedAt = DateTime.UtcNow,
        };
    }
    public StoreRegister GetRegister(int storeId, int registerId)
    {
        var registerOrNull = _dbContext.Registers
            .Where(r => r.StoreId == storeId && r.RegisterId == registerId)
            .SingleOrDefault();

        if (registerOrNull == null)
        {
            registerOrNull = GetNewStoreRegister(storeId, registerId);
            _dbContext.Registers.Add(registerOrNull);
            _dbContext.SaveChanges();
        }

        return registerOrNull;
    }

    public async Task<StoreRegister> GetRegisterAsync(int storeId, int registerId)
    {
        var registerOrNull = await _dbContext.Registers
            .Where(r => r.StoreId == storeId && r.RegisterId == registerId)
            .SingleOrDefaultAsync();

        if (registerOrNull == null)
        {
            registerOrNull = GetNewStoreRegister(storeId, registerId);
            _dbContext.Registers.Add(registerOrNull);
            await _dbContext.SaveChangesAsync();
        }

        return registerOrNull;
    }

    public async Task UpsertRegisterAsync(StoreRegister register)
    {
        var registerOrNull = await _dbContext.Registers
            .SingleOrDefaultAsync(r => r.StoreId == register.StoreId && r.RegisterId == register.RegisterId);

        if (registerOrNull is not null)
        {
            register.UpdatedAt = DateTime.UtcNow;
            _dbContext.Registers.Update(register);
        }
        else
        {
            register.CreatedAt = register.UpdatedAt = DateTime.UtcNow;
            _dbContext.Registers.Add(register);
        }

        await _dbContext.SaveChangesAsync();
    }
}
