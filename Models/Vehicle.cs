namespace CargoExpress.Models;

public class Vehicle
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public int Capacity { get; set; }

    public decimal PricePerKm { get; set; }

    public bool IsAvailable { get; set; } = true;

    public string Icon { get; set; } = "🚛";
}