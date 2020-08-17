# IdentityServer

This Project is for a least trying to understand how and what u need to IdentityServer Work using Clean Architecture

## Technologies

- .NET Core 3.1
- ASP .NET Core 3.1
- Entity Framework Core 3.1
- FluentValidation

## Migrations ###( All Cmds in the root of the repository)

    Requirements
    * dotnet new tool-manifest
    * dotnet tool install dotnet-ef

Add Migration

- `dotnet ef migrations add Initial -p Infrastructure/ -s WebUi/ -o Persistence/Migrations`

Remove Migration

- `dotnet ef migrations remove -p Infrastructure/ -s WebUi/`

Database

- `dotnet ef database update -s WebUI/`
- `dotnet ed database drop -s WebUI/`

## ## Additional Information

- CleanArchitecture <https://github.com/jasontaylordev/CleanArchitecture>
