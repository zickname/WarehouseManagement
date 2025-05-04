using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManagement.Entities;

namespace WarehouseManagement.EntityConfigurations;

public class StockItemConfiguration : IEntityTypeConfiguration<StockItemEntity>
{
    public void Configure(EntityTypeBuilder<StockItemEntity> builder)
    {
        builder.ToTable("stock_items");

        builder.HasKey(s => s.Id);

        builder.HasIndex(s => new { s.WarehouseId, s.ProductId }).IsUnique();

        builder.Property(s => s.Quantity).IsRequired();

        builder.HasOne(s => s.Warehouse)
            .WithMany(w => w.StockItems)
            .HasForeignKey(s => s.WarehouseId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(s => s.Product)
            .WithMany(p => p.StockItems)
            .HasForeignKey(s => s.ProductId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}