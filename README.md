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

dotnet run --launch-profile https

&nbsp;

## OpenAPI Specs

localhost:5044/swagger

&nbsp;

## Contributing

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