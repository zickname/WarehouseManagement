using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManagement.Entities;

namespace WarehouseManagement.EntityConfigurations;

public class ReceiptDocumentConfiguration : IEntityTypeConfiguration<ReceiptDocumentEntity>
{
    public void Configure(EntityTypeBuilder<ReceiptDocumentEntity> builder)
    {
        builder.ToTable("receipt_documents");

        builder.HasKey(r => r.Id);

        builder.Property(r => r.Date).IsRequired();

        builder.HasOne(r => r.Warehouse)
            .WithMany()
            .HasForeignKey(r => r.WarehouseId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}