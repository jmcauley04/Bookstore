using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Bookstore.Models.Entities;
using Bookstore.Data.Utility;

namespace Bookstore.Data;

public partial class BookstoreDbContext
{
    public required DbSet<ProductInventory> Inventory { get; set; }
}

internal class InventoryConfiguration : IEntityTypeConfiguration<ProductInventory>
{
    public void Configure(EntityTypeBuilder<ProductInventory> builder)
    {
        builder.ToTable("inventory", "entities")
            .HasKey(x => new { x.StoreId, x.ProductId });

        builder.Property(e => e.StoreId).HasColumnName("store_id");
        builder.Property(e => e.ProductId).HasColumnName("product_id");
        builder.Property(e => e.Quantity).HasColumnName("quantity");
        builder.Property(e => e.CreatedAt)
            .HasColumnName("created_at")
            .HasConversion<UtcDateTimeConverter>();
        builder.Property(e => e.UpdatedAt)
            .HasColumnName("updated_at")
            .HasConversion<UtcDateTimeConverter>();
    }
}
