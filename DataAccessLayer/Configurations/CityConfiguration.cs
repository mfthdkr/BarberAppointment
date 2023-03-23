using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City
                {
                    Id= 1,
                    CreatedOn=DateTime.Now,
                    ModifiedOn= DateTime.Now,
                    IsDeleted=false,
                    DeletedOn=DateTime.Now,
                    Name="Ankara",
            
                },
                new City
                {
                    Id = 2,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Name = "İstanbul",

                }
                );
        }
    }
}
