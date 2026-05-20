namespace CargoExpress.Models;

public class Price
{
    public int Id { get; set; }

    public string Route { get; set; } = string.Empty;

    public decimal PriceValue { get; set; }

    public string Unit { get; set; } = "руб/км";

    public string Description { get; set; } = string.Empty;
}