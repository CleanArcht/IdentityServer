using System.Reflection;
using IdentityServer4.EntityFramework.Options;
using Infrastructure.Identity;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


// What it does? Allows creations and configurations on tables and columns throw migrations 

namespace Infrastructure.Persistence
{
    // ApiAuthorizationDbContext ( Database abstraction for a combined DbContext using ASP.NET Identity and Identity Server)
    // A DbContext instance represents a combination of the Unit Of Work and Repository patterns such that it can be used to query from a database
    // and group together changes that will then be written back to the store as a unit

    //Constructor es el primero en ejecutarse el objetivo principal es inicializar los atributos
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        // Es el minimo codigo para poder usar 
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
         : base(options, operationalStoreOptions) { }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }


    }




}