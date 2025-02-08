using Bookstore.Transact.Transactions.Purchase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookstore.Data;

public partial class BookstoreDbContext
{
    public required DbSet<PurchaseTransaction> PurchaseTransactions { get; set; }
}

internal class PurchaseTransactionConfiguration : IEntityTypeConfiguration<PurchaseTransaction>
{
    public void Configure(EntityTypeBuilder<PurchaseTransaction> builder)
    {
        builder.ToTable("transactions_purchase", "transact")
            .HasKey(x => x.ID);
        builder.Property(e => e.ID).HasColumnName("id");
        builder.Property(e => e.TransactionID).HasColumnName("transaction_id");
        builder.Property(e => e.ProductID).HasColumnName("product_id");
        builder.Property(e => e.Quantity).HasColumnName("quantity");
    }
}
