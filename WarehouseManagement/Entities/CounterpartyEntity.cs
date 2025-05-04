namespace WarehouseManagement.Entities;

public class CounterpartyEntity
{
    public int Id { get; }

    public required string Name { get; set; }

    public required bool IsCustomer { get; set; }

    public required bool IsSupplier { get; set; }

    public DateTimeOffset CreatedDate { get; set; }
}