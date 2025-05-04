using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManagement.Entities;

namespace WarehouseManagement.EntityConfigurations;

public class SaleItemConfiguration : IEntityTypeConfiguration<SaleItemEntity>
{
    public void Configure(EntityTypeBuilder<SaleItemEntity> builder)
    {
        builder.ToTable("sale_items");

        builder.HasKey(i => i.Id);

        builder.HasOne(i => i.SaleDocument)
            .WithMany(d => d.Items)
            .HasForeignKey(i => i.SaleDocumentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(i => i.Product)
            .WithMany()
            .HasForeignKey(i => i.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}