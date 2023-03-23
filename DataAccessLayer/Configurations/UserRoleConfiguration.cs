using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {


            builder.HasData(
                new UserRole
                {
                    UserId = "e26796d3-0f85-48fe-a864-4f523107c3bb",
                    RoleId = "35ca7aad-d2b3-49f4-ad0c-1fdbc2ed7ed8"
                });
        }
    }
}
