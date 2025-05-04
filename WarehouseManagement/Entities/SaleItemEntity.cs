namespace WarehouseManagement.Entities;

public class SaleItemEntity
{
    public int Id { get; set; }
    
    public int SaleDocumentId { get; set; }
    
    public SaleDocumentEntity? SaleDocument { get; set; }
    
    public int ProductId { get; set; }
    
    public ProductEntity? Product { get; set; }
    
    public int Quantity { get; set; }
}