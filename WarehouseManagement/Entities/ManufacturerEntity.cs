namespace WarehouseManagement.Entities;

public class ManufacturerEntity
{
    public int Id { get; }
    
    public required string Name { get; set; }
    
    public DateTimeOffset CreatedDate { get; set; }
}