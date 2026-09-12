# Autohändler (Car Dealership) — Part 2

An ASP.NET Core MVC web application for managing a car dealership. You can create,
edit and delete **cars**, **manufacturers** and **car sales**, backed by a Microsoft
SQL Server database via Entity Framework Core. This is Part 2, which adds further
extensions on top of the original project.

## Features

- CRUD management for cars (`Auto`), manufacturers (`Hersteller`) and sales
  (`Autoverkaeufe`).
- Relational data model with EF Core migrations.
- Server-rendered Razor views with runtime compilation.

## Tech

- C#, ASP.NET Core MVC, .NET 6.
- Entity Framework Core 6 with the SQL Server provider (LocalDB by default).

## Run

Requires the .NET 6 SDK and SQL Server / LocalDB.

```bash
cd Autohaendler
dotnet ef database update   # apply migrations
dotnet run
```

The default connection string in `appsettings.json` points at
`(localdb)\MSSQLLocalDB`. Open the printed local URL in your browser.
