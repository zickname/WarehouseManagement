using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManagement.Entities;

namespace WarehouseManagement.EntityConfigurations;

public class MovementDocumentConfiguration : IEntityTypeConfiguration<MovementDocumentEntity>
{
    public void Configure(EntityTypeBuilder<MovementDocumentEntity> builder)
    {
        builder.ToTable("movement_documents");

        builder.HasKey(m => m.Id);

        builder.HasOne(m => m.SourceWarehouse)
            .WithMany()
            .HasForeignKey(m => m.SourceWarehouseId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(m => m.DestinationWarehouse)
            .WithMany()
            .HasForeignKey(m => m.DestinationWarehouseId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}