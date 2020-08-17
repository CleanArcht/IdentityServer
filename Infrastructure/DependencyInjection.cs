using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure
{
    // Donde todo empieza 
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {


            // A DbContext instance represents a combination of the Unit Of Work and Repository patterns such that it can be used to query from a database
            // and group together changes that will then be written back to the store as a unit
            // https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity-api-authorization?view=aspnetcore-3.0#example-deploy-to-azure-websites
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
            ));

            // Identity with the default UI:
            services.AddDefaultIdentity<ApplicationUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            // Servidor de autenticacion central para multiples apps, permite implementar el inicio de sesion unico y control de acceso
            // IdentityServer with an additional AddApiAuthorization helper method that sets up some default ASP.NET Core conventions on top of IdentityServe
            services.AddIdentityServer()
            .AddApiAuthorization<ApplicationUser, ApplicationDbContext>();


            // Configurations for password, user  or lockout settings 
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
            });


            // Authentication with an additional AddIdentityServerJwt helper method that configures the app to validate 
            // JWT tokens produced by IdentityServer. Adds an authentication handler for an API that coexists with an Authorization
            services.AddAuthentication()
               .AddIdentityServerJwt();

            return services;
        }

    }
}