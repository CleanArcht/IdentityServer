# WebUI

For generate this project use : * dotnet new Angular -n WebUI -o WebUI/ -au Indiviual

- Delete app.db, folder model and data cause we wont use.
- Remove references from csproj  app.db, Startup, Pages/Shared/_LoginPartial.cshtml
- Add reference to Pages/Shared/_LoginPartial.cshtml @using Infrastructure.Identity;

This Project is for a least trying to understand how and what u need to IdentityServer Work using Clean Architecture

## First Steps

- add Conecction string on appsettings.json dotnet add WebUI/WebUI.csproj reference Infrastructure/Infrastructure.csproj
- ASP .NET Core 3.1
- Entity Framework Core 3.1
- FluentValidation

## Migrations ###( All Cmds in the root of the repository)

    Requirements
    * dotnet new tool-manifest
 y
    * dotnet tool install dotnet-ef

Add Migration

- `dotnet ef migrations add Initial -p Infrastructure/ -s WebUi/ -o Persistence/Migrations` *option for more info --verbose

Remove Migration

- `dotnet ef migrations remove -p Infrastructure/ -s WebUi/`

Database

- `dotnet ef database update -s WebUI/`
- `dotnet ed database drop -s WebUI/`

## Scafollding

dotnet aspnet-codegenerator identity -dc Infrastructure.Persistence.ApplicationDbContext --files "Account.Register;Account.Login;Account.Logout"

More Information
    * <https://stackoverflow.com/questions/31246255/how-to-get-the-username-not-email-inside-loginpartial-cshtml-asp-net-ident>

    * <https://www.youtube.com/watch?v=CzRM-hOe35o&t=15s>

## Requirements

## Additional Information

- For more information <https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity-api-authorization?view=aspnetcore-3.0#example-deploy-to-azure-websites>
- Scaffolding <https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-3.1&tabs=netcore-cli#scaffold-identity-into-an-mvc-project-with-authorization>
