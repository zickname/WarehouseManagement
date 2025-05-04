namespace WarehouseManagement.Entities;

public class MovementItemEntity
{
    public int Id { get; set; }
    
    public int MovementDocumentId { get; set; }
    
    public MovementDocumentEntity? MovementDocument { get; set; }
    
    public int ProductId { get; set; }
    
    public ProductEntity? Product { get; set; }
    
    public int Quantity { get; set; }
}