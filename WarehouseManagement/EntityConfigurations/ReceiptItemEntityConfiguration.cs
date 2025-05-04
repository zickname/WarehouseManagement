using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManagement.Entities;

namespace WarehouseManagement.EntityConfigurations;

public class ReceiptItemConfiguration : IEntityTypeConfiguration<ReceiptItemEntity>
{
    public void Configure(EntityTypeBuilder<ReceiptItemEntity> builder)
    {
        builder.ToTable("receipt_items");

        builder.HasKey(i => i.Id);

        builder.HasOne(i => i.ReceiptDocument)
            .WithMany(d => d.Items)
            .HasForeignKey(i => i.ReceiptDocumentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(i => i.Product)
            .WithMany()
            .HasForeignKey(i => i.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}