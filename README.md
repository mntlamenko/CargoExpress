# CargoExpress

Веб-сайт транспортной компании грузоперевозок, разработанный на ASP.NET Core 8 с использованием Blazor Server и Entity Framework Core.

## Структура проекта

```
CargoExpress/
│
├── Components/                        # Blazor-компоненты
│   ├── Layout/
│   │   ├── MainLayout.razor           # Главный макет (навигация + footer)
│   │   └── NavMenu.razor              # Навигационное меню
│   │
│   ├── Pages/
│   │   ├── Index.razor                # Главная страница
│   │   ├── Services.razor             # Страница услуг
│   │   ├── Fleet.razor                # Страница автопарка
│   │   ├── Prices.razor               # Страница цен и калькулятор
│   │   ├── OrderPage.razor            # Форма оформления заявки
│   │   └── OrdersPage.razor           # Список всех заявок
│   │
│   ├── App.razor                      # Корневой HTML-документ
│   ├── Routes.razor                   # Роутинг Blazor
│   └── _Imports.razor                 # Глобальные using-директивы
│
├── Controllers/
│   └── OrdersController.cs            # REST API для заявок (GET, POST, DELETE)
│
├── Data/
│   └── CargoService.cs                # Сервис для работы с БД (DI)
│
├── Migrations/                        # Миграции Entity Framework Core
│   ├── ..._InitialCreate.cs
│   └── CargoContextModelSnapshot.cs
│
├── Models/                            # Модели данных (таблицы БД)
│   ├── CargoContext.cs                # DbContext + начальные данные (Seed)
│   ├── Order.cs                       # Заявка клиента
│   ├── Price.cs                       # Тариф
│   ├── Service.cs                     # Услуга компании
│   └── Vehicle.cs                     # Транспортное средство
│
├── wwwroot/                           # Статические файлы
│   ├── bootstrap/
│   │   └── bootstrap.min.css          # Bootstrap 5
│   ├── app.css                        # Пользовательские стили
│   └── favicon.png
│
├── .dockerignore
├── .gitignore
├── appsettings.json                   # Настройки приложения (строка подключения к БД)
├── appsettings.Development.json
├── cargo.db                           # База данных SQLite (создаётся автоматически)
├── docker-compose.yml                 # Конфигурация Docker Compose
├── Dockerfile                         # Сборка Docker-образа
├── Program.cs                         # Точка входа, регистрация сервисов
└── README.md
```

## Установка и запуск

### Требования

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (или VS Code)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)

### Вариант 1 — Запуск через Visual Studio 2022

**1. Клонировать репозиторий**

```bash
git clone https://github.com/<ваш-логин>/CargoExpress.git
cd CargoExpress
```

**2. Открыть решение**

Откройте файл `CargoExpress.slnx` в Visual Studio 2022.

**3. Установить зависимости**

В меню: **Инструменты → Диспетчер пакетов NuGet → Консоль диспетчера пакетов**

```
dotnet restore
```

**4. Применить миграции**

```
Update-Database
```

База данных `cargo.db` создастся автоматически и заполнится тестовыми данными.

**5. Запустить проект**

Нажмите **F5** или кнопку **Запустить**.

Сайт откроется по адресу: `https://localhost:5252`

---

### Вариант 2 — Запуск через командную строку (dotnet CLI)

```bash
# Клонировать репозиторий
git clone https://github.com/<ваш-логин>/CargoExpress.git
cd CargoExpress

# Восстановить пакеты
dotnet restore

# Применить миграции
dotnet ef database update

# Запустить приложение
dotnet run
```

Сайт будет доступен по адресу: `http://localhost:5000`

---

### Вариант 3 — Запуск через Docker

```bash
# Клонировать репозиторий
git clone https://github.com/<ваш-логин>/CargoExpress.git
cd CargoExpress

# Собрать и запустить контейнер
docker-compose up -d
```

Сайт будет доступен по адресу: `http://localhost:5000`

Остановить контейнер:

```bash
docker-compose down
```
