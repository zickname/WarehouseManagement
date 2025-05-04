namespace WarehouseManagement.Entities;

public class StockItemEntity
{
    public int Id { get; set; }
    
    public int WarehouseId { get; set; }
    
    public WarehouseEntity? Warehouse { get; set; }
    
    public int ProductId { get; set; }
    
    public ProductEntity? Product { get; set; }
    
    public int Quantity { get; set; }
}