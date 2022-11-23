using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Configurations
{
    public class ApplicationRoleConfiguration :IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.HasData(
                new ApplicationRole
                {
                    Id = "35ca7aad-d2b3-49f4-ad0c-1fdbc2ed7ed8",
                    Name = "Administrator",
                    NormalizedName= "ADMINISTRATOR",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    CreatedOn = DateTime.Now,
                    ModifiedOn =DateTime.Now,
                    IsDeleted =false,
                    DeletedOn = DateTime.Now
                    
                },
                new ApplicationRole
                {
                    Id = "ab2e09bf-cc27-43b5-bed9-1cc81c957abb",
                    Name = "Manager",
                    NormalizedName = "MANAGER",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,

                });

        }

    }
}
