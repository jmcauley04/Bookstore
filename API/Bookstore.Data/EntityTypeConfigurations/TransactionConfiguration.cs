using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Transact.Models;

namespace Bookstore.Data;

public partial class BookstoreDbContext
{
    public required DbSet<Transaction> Transactions { get; set; }
}

internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.ToTable("transactions", "transact")
            .HasKey(x => x.ID);

        builder.Property(e => e.ID).HasColumnName("id");
        builder.Property(e => e.Timestamp).HasColumnName("timestamp");
        builder.Property(e => e.Amount).HasColumnName("amount");
        builder.Property(e => e.Type).HasColumnName("type");
        builder.Property(e => e.CategoryId).HasColumnName("category_id");
        builder.Property(e => e.Comments).HasColumnName("comments");
        //builder.HasDiscriminator<string>("TransactionType")
        //    .HasValue<Transaction>("Transaction")
        //    .HasValue<StoreMerchTransaction>("StoreMerchTransaction");
    }
}
