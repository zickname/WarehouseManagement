namespace WarehouseManagement.Entities;

public class ReceiptDocumentEntity
{
    public int Id { get; set; }
    
    public DateTime Date { get; set; }
    
    public int WarehouseId { get; set; }
    
    public WarehouseEntity? Warehouse { get; set; }
    
    public ICollection<ReceiptItemEntity> Items { get; set; } = new List<ReceiptItemEntity>();
}