using Microsoft.EntityFrameworkCore;
using WarehouseManagement.Contracts;
using WarehouseManagement.Entities;
using WarehouseManagement.Services.Database;

namespace WarehouseManagement.Endpoints.Warehouses;

public static class WarehouseEndpoints
{
    public static void MapWarehouseEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapPost("/warehouses", Create)
            .WithOpenApi();

        endpoints.MapGet("/warehouses", GetAll)
            .WithOpenApi();

        endpoints.MapGet("/warehouses/{warehouseId}", GetById)
            .WithOpenApi();

        endpoints.MapPut("/warehouses/{warehouseId}", Update)
            .WithOpenApi();

        endpoints.MapDelete("/warehouses/{id}", Delete)
            .WithOpenApi();
    }

    private static async Task<IResult> Create(AppDbContext _context, WarehouseDto dto)
    {
        var warehouse = new WarehouseEntity()
        {
            Name = dto.Name,
            Location = dto.Location
        };

        _context.Warehouses.Add(warehouse);

        await _context.SaveChangesAsync();

        return Results.Created($"/warehouses/{warehouse.Id}", warehouse);
    }

    private static async Task<IResult> GetAll(AppDbContext _context)
    {
        var warehouses = await _context.Warehouses.ToListAsync();

        return Results.Ok(warehouses);
    }

    private static async Task<IResult> GetById(AppDbContext _context, int warehouseId)
    {
        var warehouse = await _context.Warehouses.FindAsync(warehouseId);

        return warehouse is not null ? Results.Ok(warehouse) : Results.NotFound();
    }

    private static async Task<IResult> Update(AppDbContext _context, int warehouseId, WarehouseDto dto)
    {
        var warehouse = await _context.Warehouses.FindAsync(warehouseId);

        if (warehouse is null) return Results.NotFound();

        warehouse.Name = dto.Name;
        warehouse.Location = dto.Location;

        await _context.SaveChangesAsync();
        return Results.NoContent();
    }

    private static async Task<IResult> Delete(AppDbContext _context, int id)
    {
        var warehouse = await _context.Warehouses.FindAsync(id);

        if (warehouse is null) return Results.NotFound();

        _context.Warehouses.Remove(warehouse);

        await _context.SaveChangesAsync();

        return Results.NoContent();
    }
}