using Bookstore.Transact.Transactions.StoreMerch;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookstore.Data;

public partial class BookstoreDbContext
{
    public required DbSet<StoreMerchTransaction> StoreMerchTransactions { get; set; }
}

internal class StoreMerchTransactionConfiguration : IEntityTypeConfiguration<StoreMerchTransaction>
{
    public void Configure(EntityTypeBuilder<StoreMerchTransaction> builder)
    {
        builder.ToTable("transactions_store_merch", "transact")
            .HasKey(x => x.ID);
        builder.Property(e => e.ID).HasColumnName("id");
        builder.Property(e => e.TransactionID).HasColumnName("transaction_id");
        builder.Property(e => e.StoreID).HasColumnName("store_id");
        builder.Property(e => e.RegisterID).HasColumnName("register_id");
        builder.Property(e => e.CustomerID).HasColumnName("customer_id");
        builder.Property(e => e.AssociateID).HasColumnName("associate_id");
    }
}
