# Code Assessment API

 A C# .NET Core API for managing library transactions. For a quick start, jump to [Getting Started](# Getting Started)

&nbsp;

## Prerequisites

- [Docker](https://docs.docker.com/engine/install/) installed on your machine
- [.NET Core 8+](https://dotnet.microsoft.com/download) installed on your machine
- [Git](https://git-scm.com/download/) installed on your machine
- [Visual Studio Code](https://code.visualstudio.com/) installed on your machine

&nbsp;

## Repository Overview

```bash
/CodeAssessmentAPI
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

### Launch an instance of SQL Server

Run the following docker script to launch a container hosting SQL Server:

```bash
cd docker
bash build.sh
cd ..
```

### Restore installs

```bash
dotnet restore
```

### Generate & Trust a Development Cert

```bash
dotnet dev-certs https --trust
```

### Start the application

Once the instance is live, start the app:

```bash
dotnet run --launch-profile https
```

### View the OpenAPI Specs

[The OpenAPI specs can now be found here](https://localhost:7120/swagger)

&nbsp;

## Contributing

### Logical Breakdown of Concepts

- Model (type defining)
- Controller (routing(req/res) & auth)
- Service (Handling)

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

### Controller Development

To generate a controller template, run the following:

```bash
dotnet aspnet-codegenerator controller -name [MODEL_NAME]Controller -async -api -m [MODEL_NAME] -dc [MODEL_NAME]Context -outDir Controllers
```

Adjust the controller as required for the instance.

### Authenticating Endpoints

Add `[Authorization]` above the route.

> By default this will require the requested user to be logged in

Can also manage roles: `[Authorization(roles = "Employee")]`

### Migration Scripts

Ensure .NET Entity Framework is installed
```bash
dotnet tool install --global dotnet-ef
```

Create a migration:
```bash
dotnet ef migrations add NewMigrationTitle -o Data/Migrations
```

Remove a migration:
```bash
dotnet ef migrations remove
```

Update the database:
```bash
dotnet ef database update
```

### Code formatting:

```bash
dotnet format code-assessment-api.sln
```

## Documentation

[Download Docker](https://www.docker.com/products/docker-desktop/)
[Download .NET 8+](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
[.NET 8+ Web API](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio-code)
[.NET Migrations](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)
[.NET Identity](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity-api-authorization?view=aspnetcore-8.0)
[Prevent Over Posting](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity-api-authorization?view=aspnetcore-8.0)
[Creating a Pipeline](https://learn.microsoft.com/en-us/azure/devops/pipelines/create-first-pipeline?view=azure-devops&tabs=net%2Cbrowser)