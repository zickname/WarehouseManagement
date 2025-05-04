using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManagement.Entities;

namespace WarehouseManagement.EntityConfigurations;

public class MovementItemConfiguration : IEntityTypeConfiguration<MovementItemEntity>
{
    public void Configure(EntityTypeBuilder<MovementItemEntity> builder)
    {
        builder.ToTable("movement_items");

        builder.HasKey(i => i.Id);

        builder.HasOne(i => i.MovementDocument)
            .WithMany(d => d.Items)
            .HasForeignKey(i => i.MovementDocumentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(i => i.Product)
            .WithMany()
            .HasForeignKey(i => i.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}