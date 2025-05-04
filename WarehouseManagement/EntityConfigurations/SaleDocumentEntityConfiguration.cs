using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManagement.Entities;

namespace WarehouseManagement.EntityConfigurations;

public class SaleDocumentEntityConfiguration
{
    public class SaleDocumentConfiguration : IEntityTypeConfiguration<SaleDocumentEntity>
    {
        public void Configure(EntityTypeBuilder<SaleDocumentEntity> builder)
        {
            builder.ToTable("sale_documents");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Date).IsRequired();

            builder.HasOne(s => s.Warehouse)
                .WithMany()
                .HasForeignKey(s => s.WarehouseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}