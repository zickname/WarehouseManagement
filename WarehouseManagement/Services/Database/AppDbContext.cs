using System.Reflection;
using Microsoft.EntityFrameworkCore;
using WarehouseManagement.Entities;

namespace WarehouseManagement.Services.Database;

public class AppDbContext(IConfiguration configuration) : DbContext
{
    public DbSet<WarehouseEntity> Warehouses => Set<WarehouseEntity>();

    public DbSet<ProductEntity> Products => Set<ProductEntity>();

    public DbSet<StockItemEntity> StockItems => Set<StockItemEntity>();

    public DbSet<ReceiptDocumentEntity> ReceiptDocuments => Set<ReceiptDocumentEntity>();

    public DbSet<ReceiptItemEntity> ReceiptItems => Set<ReceiptItemEntity>();

    public DbSet<MovementDocumentEntity> MovementDocuments => Set<MovementDocumentEntity>();

    public DbSet<MovementItemEntity> MovementItems => Set<MovementItemEntity>();

    public DbSet<SaleDocumentEntity> SaleDocuments => Set<SaleDocumentEntity>();

    public DbSet<SaleItemEntity> SaleItems => Set<SaleItemEntity>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnections"))
            .UseNpgsql().UseSnakeCaseNamingConvention()
            .LogTo(Console.WriteLine, LogLevel.Information);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}