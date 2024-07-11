# Code Assessment API

 A C# .NET Core API for managing library transactions. For a quick start, jump to [Getting Started](# Getting Started)

&nbsp;

## Prerequisites

- [Docker](https://docs.docker.com/engine/install/) installed on your machine
- Basic knowledge of [Docker](https://docs.docker.com/get-started/overview/)
- Basic knowledge of [SQLServer](https://learn.microsoft.com/en-us/sql/sql-server/?view=sql-server-ver16)
- [Docker](https://docs.docker.com/engine/install/) installed on your machine
- [.NET Core 8+](https://dotnet.microsoft.com/download) installed on your machine

&nbsp;

## Repository Overview

```bash
/MyWebAPI
│
├── /bin
├── /Controllers
│   ├── UserController.cs
│   └── ...
├── /Docker # SQL Container Setup
├── /Migrations
├── /Models
│   ├── User.cs
│   ├── UserContext.cs
│   └── ...
├── /Seeders
├── /Services
│   ├── UserService.cs
│   └── ...
├── /Repositories
├── /Properties
├── appsettings.json
├── appsettings.Development.json
├── Program.cs
├── MyWebAPI.csproj
├── MyWebAPI.sln
└── README.md
```

&nbsp;

## Getting Started / Running the app

```bash
dotnet run --launch-profile https
```

&nbsp;

## OpenAPI Specs

localhost:5044/swagger

&nbsp;

## Contributing

### Logical Breakdown of Concepts

Model (type defining)
Controller (routing(req/res) & auth)
Service (Handling)

### Adding a Package

```bash
dotnet add package PACKAGE_NAME
```

### Creating a Model

Add a `[MODEL_NAME].cs`  file to `/Model` holding object/type data:

```cs
namespace Models;

public class Model
{
    public long Id { get; set; }
    ...
}
```

Additionally, create a database context file `[MODEL_NAME]Context.cs` for the new model:

```cs
public class ModelContext : DbContext
{
    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {}
    ...
}
```

&nbsp;

### Controller Development

To generate a controller template, run the following:

```bash
dotnet aspnet-codegenerator controller -name [MODEL_NAME]Controller -async -api -m [MODEL_NAME] -dc [MODEL_NAME]Context -outDir Controllers
```

Adjust the controller as required for the instance.

&nbsp;

### Migration Scripts

```bash
dotnet ef migrations add NewMigrationTitle
```

&nbsp;

### Creating a Seed Script

SEED SCRIPT INFO

&nbsp;

## Documentation

[Download Docker](https://www.docker.com/products/docker-desktop/)
[Download .NET 8+](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
[.NET 8+ Web API](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio-code)
[.NET Migrations](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)
[.NET Identity](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity-api-authorization?view=aspnetcore-8.0)
[Prevent Over Posting](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity-api-authorization?view=aspnetcore-8.0)