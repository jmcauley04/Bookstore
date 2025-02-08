using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data;

public partial class BookstoreDbContext(DbContextOptions<BookstoreDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookstoreDbContext).Assembly);
    }
}
