namespace WarehouseManagement.Entities;

public class CategoryEntity
{
    
    public required string Name { get; set; }
    
    public Guid? ParentCategoryId { get; set; }
    
    public CategoryEntity? ParentCategory { get; set; }

    public DateTimeOffset CreatedDate { get; set; }
    
    public List<CategoryEntity> SubCategories { get; set; } = [];

    public ICollection<ProductEntity> Products { get; set; } = null!;
}