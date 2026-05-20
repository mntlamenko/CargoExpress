namespace CargoExpress.Models;

public class Service
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Details { get; set; } = string.Empty;

    public decimal BasePrice { get; set; }

    public string Icon { get; set; } = "📦";
}