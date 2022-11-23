using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Configurations
{
    public class SalonConfiguration : IEntityTypeConfiguration<Salon>
    {
        public void Configure(EntityTypeBuilder<Salon> builder)
        {
            builder.HasData(
                new Salon {
                    Id="salon1",
                    CreatedOn= DateTime.Now,
                    ModifiedOn= DateTime.Now,
                    IsDeleted=false,
                    DeletedOn= DateTime.Now,
                    Name="Erkek Kuaför 1",
                    ImageUrl= "../images/Salons/ManSalon.jfif",
                    OwnerId= null,
                    CategoryId= 1,
                    CityId =2,
                    Address= "Zeytinburnu",
                    Rating= 0,
                    RatersCount=0
                },
                new Salon
                {
                    Id = "salon2",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Name = "Erkek Kuaför 2",
                    ImageUrl = "../images/Salons/ManSalon.jfif",
                    OwnerId = null,
                    CategoryId = 1,
                    CityId = 2,
                    Address = "Zeytinburnu",
                    Rating = 0,
                    RatersCount = 0
                },
                new Salon
                {
                    Id = "salon3",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Name = "Erkek Kuaför 3",
                    ImageUrl = "../images/Salons/ManSalon.jfif",
                    OwnerId = null,
                    CategoryId = 1,
                    CityId = 2,
                    Address = "Zeytinburnu",
                    Rating = 0,
                    RatersCount = 0
                },
                new Salon
                {
                    Id = "salon4",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Name = "Erkek Kuaför 4",
                    ImageUrl = "../images/Salons/ManSalon.jfif",
                    OwnerId = null,
                    CategoryId = 1,
                    CityId = 2,
                    Address = "Zeytinburnu",
                    Rating = 0,
                    RatersCount = 0
                },
                new Salon
                {
                    Id = "salon5",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Name = "Erkek Kuaför 5",
                    ImageUrl = "../images/Salons/ManSalon.jfif",
                    OwnerId = null,
                    CategoryId = 1,
                    CityId = 2,
                    Address = "Zeytinburnu",
                    Rating = 0,
                    RatersCount = 0
                },
                new Salon
                {
                    Id = "salon6",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Name = "Kadın Kuaför 1",
                    ImageUrl = "../images/Salons/WomanSalon.jpg",
                    OwnerId = null,
                    CategoryId = 2,
                    CityId = 1,
                    Address = "Keçiören",
                    Rating = 0,
                    RatersCount = 0
                },
                new Salon
                {
                    Id = "salon7",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Name = "Kadın Kuaför 2",
                    ImageUrl = "../images/Salons/WomanSalon.jpg",
                    OwnerId = null,
                    CategoryId = 2,
                    CityId = 1,
                    Address = "Keçiören",
                    Rating = 0,
                    RatersCount = 0
                },
                new Salon
                {
                    Id = "salon8",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Name = "Kadın Kuaför 3",
                    ImageUrl = "../images/Salons/WomanSalon.jpg",
                    OwnerId = null,
                    CategoryId = 2,
                    CityId = 1,
                    Address = "Keçiören",
                    Rating = 0,
                    RatersCount = 0
                },
                new Salon
                {
                    Id = "salon9",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Name = "Kadın Kuaför 4",
                    ImageUrl = "../images/Salons/WomanSalon.jpg",
                    OwnerId = null,
                    CategoryId = 2,
                    CityId = 1,
                    Address = "Keçiören",
                    Rating = 0,
                    RatersCount = 0
                },
                new Salon
                {
                    Id = "salon10",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Name = "Kadın Kuaför 5",
                    ImageUrl = "../images/Salons/WomanSalon.jpg",
                    OwnerId = null,
                    CategoryId = 2,
                    CityId = 1,
                    Address = "Keçiören",
                    Rating = 0,
                    RatersCount = 0
                },
                new Salon
                {
                    Id = "salon11",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Name = "Kadın Kuaför 6",
                    ImageUrl = "../images/Salons/WomanSalon.jpg",
                    OwnerId = null,
                    CategoryId = 2,
                    CityId = 1,
                    Address = "Keçiören",
                    Rating = 0,
                    RatersCount = 0
                }


                );
        }
    }
}
