namespace Bookstore.Data.Repositories;

public abstract class BookstoreRepository(BookstoreDbContext dbContext)
{
    protected readonly BookstoreDbContext _dbContext = dbContext;

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0063:Use simple 'using' statement", Justification = "<Pending>")]
    public async Task UsingTransaction(Func<Task> task)
    {
        using (var dbTransaction = await _dbContext.Database.BeginTransactionAsync())
        {
            try
            {
                await task();
                await dbTransaction.CommitAsync();
            }
            catch
            {
                await dbTransaction.RollbackAsync();
                throw;
            }
        }
    }
}
