namespace WarehouseManagement.Entities;

public class ReceiptItemEntity
{
    public int Id { get; set; }
    
    public int ReceiptDocumentId { get; set; }
    
    public ReceiptDocumentEntity? ReceiptDocument { get; set; }
    
    public int ProductId { get; set; }
    
    public ProductEntity? Product { get; set; }
    
    public int Quantity { get; set; }
}