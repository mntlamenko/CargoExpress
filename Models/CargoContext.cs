using Microsoft.EntityFrameworkCore;

namespace CargoExpress.Models;

public class CargoContext : DbContext
{

    public CargoContext(DbContextOptions<CargoContext> options) : base(options) { }

    public DbSet<Service> Services { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Price> Prices { get; set; }
    public DbSet<Order> Orders { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Service>().HasData(
            new Service
            {
                Id = 1,
                Name = "Грузоперевозки по городу",
                Description = "Быстрая доставка в черте города на любом расстоянии",
                Details = "Перевозим мебель, технику, стройматериалы. Грузчики в наличии. Работаем 7 дней в неделю с 8:00 до 22:00.",
                BasePrice = 500,
                Icon = "🏙️"
            },
            new Service
            {
                Id = 2,
                Name = "Межгород",
                Description = "Надёжная доставка между городами России",
                Details = "Доставляем грузы по всей России. Страхование груза. GPS-отслеживание. Срок доставки от 1 дня.",
                BasePrice = 25,
                Icon = "🛣️"
            },
            new Service
            {
                Id = 3,
                Name = "Квартирный переезд",
                Description = "Полный цикл переезда с упаковкой и разборкой мебели",
                Details = "Бригада грузчиков, упаковочные материалы, разборка и сборка мебели. Страховка имущества включена.",
                BasePrice = 3000,
                Icon = "🏠"
            },
            new Service
            {
                Id = 4,
                Name = "Офисный переезд",
                Description = "Перевозка офиса без простоев — в выходные или ночью",
                Details = "Разберём, упакуем, перевезём и соберём всё оборудование. Работаем ночью и в выходные для минимального простоя бизнеса.",
                BasePrice = 5000,
                Icon = "🏢"
            },
            new Service
            {
                Id = 5,
                Name = "Перевозка вещей",
                Description = "Небольшой объём вещей — быстро и недорого",
                Details = "Перевезём сумки, коробки, бытовую технику. Газель или минивэн. Идеально для студентов и небольших переездов.",
                BasePrice = 800,
                Icon = "📦"
            },
            new Service
            {
                Id = 6,
                Name = "Доставка стройматериалов",
                Description = "Перевозка кирпича, плитки, цемента, стекла",
                Details = "Специализированные автомобили для стройматериалов. Манипулятор для тяжёлых грузов. Доставка на объект.",
                BasePrice = 1500,
                Icon = "🧱"
            }
        );

        modelBuilder.Entity<Vehicle>().HasData(
            new Vehicle
            {
                Id = 1,
                Name = "Газель",
                Model = "ГАЗ-3302",
                Capacity = 2,
                PricePerKm = 25,
                IsAvailable = true,
                Icon = "🚐"
            },
            new Vehicle
            {
                Id = 2,
                Name = "Газель Некст",
                Model = "ГАЗ-А21R22",
                Capacity = 3,
                PricePerKm = 30,
                IsAvailable = true,
                Icon = "🚐"
            },
            new Vehicle
            {
                Id = 3,
                Name = "Фура",
                Model = "MAN TGX 18.440",
                Capacity = 20,
                PricePerKm = 80,
                IsAvailable = false,
                Icon = "🚛"
            },
            new Vehicle
            {
                Id = 4,
                Name = "Среднетоннажник",
                Model = "КАМАЗ-4308",
                Capacity = 8,
                PricePerKm = 50,
                IsAvailable = true,
                Icon = "🚚"
            },
            new Vehicle
            {
                Id = 5,
                Name = "Рефрижератор",
                Model = "Mercedes Atego",
                Capacity = 5,
                PricePerKm = 45,
                IsAvailable = true,
                Icon = "❄️"
            },
            new Vehicle
            {
                Id = 6,
                Name = "Манипулятор",
                Model = "Урал-4320",
                Capacity = 10,
                PricePerKm = 65,
                IsAvailable = false,
                Icon = "🏗️"
            }
        );

        modelBuilder.Entity<Price>().HasData(
            new Price { Id = 1, Route = "По городу (до 50 км)", PriceValue = 500, Unit = "руб/выезд", Description = "Минимальный тариф в черте города" },
            new Price { Id = 2, Route = "По городу (более 50 км)", PriceValue = 25, Unit = "руб/км", Description = "Сверх нормы — доплата за километр" },
            new Price { Id = 3, Route = "Межгород (100–500 км)", PriceValue = 30, Unit = "руб/км", Description = "Доставка в соседние регионы" },
            new Price { Id = 4, Route = "Межгород (500–1500 км)", PriceValue = 25, Unit = "руб/км", Description = "Дальние рейсы — цена ниже" },
            new Price { Id = 5, Route = "Квартирный переезд", PriceValue = 3000, Unit = "руб/смена", Description = "Бригада 2 грузчика + машина, смена 8 ч" },
            new Price { Id = 6, Route = "Офисный переезд", PriceValue = 5000, Unit = "руб/смена", Description = "Бригада 4 грузчика + крупный транспорт" },
            new Price { Id = 7, Route = "Грузчики (без авто)", PriceValue = 500, Unit = "руб/ч", Description = "Наём грузчиков на почасовой основе" },
            new Price { Id = 8, Route = "Упаковка вещей", PriceValue = 200, Unit = "руб/коробка", Description = "Упаковочные материалы и работа" }
        );
    }
}