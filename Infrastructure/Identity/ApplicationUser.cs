using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser
    {


        [PersonalData]
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
    }
}