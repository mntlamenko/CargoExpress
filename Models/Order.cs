using System.ComponentModel.DataAnnotations;

namespace CargoExpress.Models;

public class Order
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Укажите ваше имя")]
    [MinLength(2, ErrorMessage = "Имя слишком короткое")]
    public string CustomerName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Укажите email")]
    [EmailAddress(ErrorMessage = "Неверный формат email")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Укажите телефон")]
    public string Phone { get; set; } = string.Empty;

    [Required(ErrorMessage = "Укажите адрес отправления")]
    public string FromAddress { get; set; } = string.Empty;

    [Required(ErrorMessage = "Укажите адрес доставки")]
    public string ToAddress { get; set; } = string.Empty;

    [Range(0.1, 50000, ErrorMessage = "Вес должен быть от 0.1 до 50000 кг")]
    public decimal Weight { get; set; }

    public string ServiceType { get; set; } = "Грузоперевозка";

    public DateTime OrderDate { get; set; } = DateTime.Now;

    public string Status { get; set; } = "Новый";

    public string Comment { get; set; } = string.Empty;
}