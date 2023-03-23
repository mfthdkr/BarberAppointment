using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role
                {
                    Id = "35ca7aad-d2b3-49f4-ad0c-1fdbc2ed7ed8",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now

                });

        }

    }
}
