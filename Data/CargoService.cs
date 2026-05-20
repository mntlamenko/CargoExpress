using CargoExpress.Models;
using Microsoft.EntityFrameworkCore;

namespace CargoExpress.Data;

/// <summary>
/// Сервис для работы с данными.
/// Через него страницы Blazor получают данные из БД.
/// </summary>
public class CargoService
{
    private readonly CargoContext _context;

    /// <summary>
    /// DI (Dependency Injection) — .NET сам передаст CargoContext в конструктор
    /// </summary>
    public CargoService(CargoContext context)
    {
        _context = context;
    }

    public async Task<List<Service>> GetServicesAsync() =>
        await _context.Services.ToListAsync();

    public async Task<List<Vehicle>> GetVehiclesAsync() =>
        await _context.Vehicles.ToListAsync();

    public async Task<List<Price>> GetPricesAsync() =>
        await _context.Prices.ToListAsync();

    public async Task<List<Order>> GetOrdersAsync() =>
        await _context.Orders
            .OrderByDescending(o => o.OrderDate)
            .ToListAsync();


    /// <param name="order"
    public async Task<bool> CreateOrderAsync(Order order)
    {
        try
        {
            order.OrderDate = DateTime.Now;
            order.Status = "Новый";

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}