namespace WarehouseManagement.Entities;

public class WarehouseEntity
{
    public int Id { get; set; }
    
    public string Name { get; set; } = default!;
    
    public string Location { get; set; } = default!;
    
    public ICollection<StockItemEntity> StockItems { get; set; } = new List<StockItemEntity>();
}