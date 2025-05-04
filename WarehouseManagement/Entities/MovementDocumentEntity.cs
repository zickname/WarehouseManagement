namespace WarehouseManagement.Entities;

public class MovementDocumentEntity
{
    public int Id { get; set; }
    
    public DateTime Date { get; set; }
    
    public int SourceWarehouseId { get; set; }
    
    public WarehouseEntity? SourceWarehouse { get; set; }
    
    public int DestinationWarehouseId { get; set; }
    
    public WarehouseEntity? DestinationWarehouse { get; set; }
    
    public ICollection<MovementItemEntity> Items { get; set; } = new List<MovementItemEntity>();
}