using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Configurations
{
    public class ApplicationUserRoleConfiguration : IEntityTypeConfiguration<ApplicationUserRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserRole> builder)
        {
            

            builder.HasData(
                new ApplicationUserRole
                {
                    UserId = "e26796d3-0f85-48fe-a864-4f523107c3bb",
                    RoleId = "35ca7aad-d2b3-49f4-ad0c-1fdbc2ed7ed8"
                },
                new ApplicationUserRole
                {
                    UserId = "b4a23211-6cba-4cd1-9e27-0b50aa6294d9",
                    RoleId = "ab2e09bf-cc27-43b5-bed9-1cc81c957abb"
                }
                );
        }
    }
}
