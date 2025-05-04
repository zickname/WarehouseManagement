using WarehouseManagement.Enums;

namespace WarehouseManagement.Entities;

public class ProductEntity
{
    public int Id { get; set; }
    
    public string Name { get; set; } = default!;
    
    public ICollection<StockItemEntity> StockItems { get; set; } = new List<StockItemEntity>();

}