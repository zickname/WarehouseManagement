namespace WarehouseManagement.Entities;

public class SaleDocumentEntity
{
    public int Id { get; set; }
    
    public DateTime Date { get; set; }
    
    public int WarehouseId { get; set; }
    
    public WarehouseEntity? Warehouse { get; set; }
    
    public ICollection<SaleItemEntity> Items { get; set; } = new List<SaleItemEntity>();
}