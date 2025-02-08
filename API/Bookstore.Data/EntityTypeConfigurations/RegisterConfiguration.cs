using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Bookstore.Models.Entities;
using Bookstore.Data.Utility;

namespace Bookstore.Data;

public partial class BookstoreDbContext
{
    public required DbSet<StoreRegister> Registers { get; set; }
}

internal class RegisterConfiguration : IEntityTypeConfiguration<StoreRegister>
{
    public void Configure(EntityTypeBuilder<StoreRegister> builder)
    {
        builder.ToTable("registers", "entities")
            .HasKey(x => new { x.StoreId, x.RegisterId });

        builder.Property(e => e.StoreId).HasColumnName("store_id");
        builder.Property(e => e.RegisterId).HasColumnName("register_id");
        builder.Property(e => e.Cash).HasColumnName("cash_amt");
        builder.Property(e => e.Check).HasColumnName("check_amt");
        builder.Property(e => e.Credit).HasColumnName("credit_amt");
        builder.Property(e => e.CreatedAt)
            .HasColumnName("created_at")
            .HasConversion<UtcDateTimeConverter>();
        builder.Property(e => e.UpdatedAt)
            .HasColumnName("updated_at")
            .HasConversion<UtcDateTimeConverter>();
    }
}
