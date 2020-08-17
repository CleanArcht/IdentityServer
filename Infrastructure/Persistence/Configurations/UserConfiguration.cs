using Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {

        public void Configure ( EntityTypeBuilder<ApplicationUser> builder )
        {
        
            builder.Property( u => u.Name)
            // .IsRequired()
            .HasMaxLength(128);

            builder.Property( u => u.PhotoUrl).HasMaxLength(256);

        }
        
    }
}