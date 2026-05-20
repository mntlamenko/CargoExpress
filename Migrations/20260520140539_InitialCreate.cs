using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CargoExpress.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    FromAddress = table.Column<string>(type: "TEXT", nullable: false),
                    ToAddress = table.Column<string>(type: "TEXT", nullable: false),
                    Weight = table.Column<decimal>(type: "TEXT", nullable: false),
                    ServiceType = table.Column<string>(type: "TEXT", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Route = table.Column<string>(type: "TEXT", nullable: false),
                    PriceValue = table.Column<decimal>(type: "TEXT", nullable: false),
                    Unit = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Details = table.Column<string>(type: "TEXT", nullable: false),
                    BasePrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Capacity = table.Column<int>(type: "INTEGER", nullable: false),
                    PricePerKm = table.Column<decimal>(type: "TEXT", nullable: false),
                    IsAvailable = table.Column<bool>(type: "INTEGER", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "Description", "PriceValue", "Route", "Unit" },
                values: new object[,]
                {
                    { 1, "Минимальный тариф в черте города", 500m, "По городу (до 50 км)", "руб/выезд" },
                    { 2, "Сверх нормы — доплата за километр", 25m, "По городу (более 50 км)", "руб/км" },
                    { 3, "Доставка в соседние регионы", 30m, "Межгород (100–500 км)", "руб/км" },
                    { 4, "Дальние рейсы — цена ниже", 25m, "Межгород (500–1500 км)", "руб/км" },
                    { 5, "Бригада 2 грузчика + машина, смена 8 ч", 3000m, "Квартирный переезд", "руб/смена" },
                    { 6, "Бригада 4 грузчика + крупный транспорт", 5000m, "Офисный переезд", "руб/смена" },
                    { 7, "Наём грузчиков на почасовой основе", 500m, "Грузчики (без авто)", "руб/ч" },
                    { 8, "Упаковочные материалы и работа", 200m, "Упаковка вещей", "руб/коробка" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "BasePrice", "Description", "Details", "Icon", "Name" },
                values: new object[,]
                {
                    { 1, 500m, "Быстрая доставка в черте города на любом расстоянии", "Перевозим мебель, технику, стройматериалы. Грузчики в наличии. Работаем 7 дней в неделю с 8:00 до 22:00.", "🏙️", "Грузоперевозки по городу" },
                    { 2, 25m, "Надёжная доставка между городами России", "Доставляем грузы по всей России. Страхование груза. GPS-отслеживание. Срок доставки от 1 дня.", "🛣️", "Межгород" },
                    { 3, 3000m, "Полный цикл переезда с упаковкой и разборкой мебели", "Бригада грузчиков, упаковочные материалы, разборка и сборка мебели. Страховка имущества включена.", "🏠", "Квартирный переезд" },
                    { 4, 5000m, "Перевозка офиса без простоев — в выходные или ночью", "Разберём, упакуем, перевезём и соберём всё оборудование. Работаем ночью и в выходные для минимального простоя бизнеса.", "🏢", "Офисный переезд" },
                    { 5, 800m, "Небольшой объём вещей — быстро и недорого", "Перевезём сумки, коробки, бытовую технику. Газель или минивэн. Идеально для студентов и небольших переездов.", "📦", "Перевозка вещей" },
                    { 6, 1500m, "Перевозка кирпича, плитки, цемента, стекла", "Специализированные автомобили для стройматериалов. Манипулятор для тяжёлых грузов. Доставка на объект.", "🧱", "Доставка стройматериалов" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Capacity", "Icon", "IsAvailable", "Model", "Name", "PricePerKm" },
                values: new object[,]
                {
                    { 1, 2, "🚐", true, "ГАЗ-3302", "Газель", 25m },
                    { 2, 3, "🚐", true, "ГАЗ-А21R22", "Газель Некст", 30m },
                    { 3, 20, "🚛", false, "MAN TGX 18.440", "Фура", 80m },
                    { 4, 8, "🚚", true, "КАМАЗ-4308", "Среднетоннажник", 50m },
                    { 5, 5, "❄️", true, "Mercedes Atego", "Рефрижератор", 45m },
                    { 6, 10, "🏗️", false, "Урал-4320", "Манипулятор", 65m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
