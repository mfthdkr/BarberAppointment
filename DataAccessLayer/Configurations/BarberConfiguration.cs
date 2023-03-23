using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations
{
    public class BarberConfiguration : IEntityTypeConfiguration<Barber>
    {
        public void Configure(EntityTypeBuilder<Barber> builder)
        {
            builder.HasData(
                new Barber
                {
                    Id = 1,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Name = "Erkek Kuaför 1",
                    ImageUrl = "../images/Barbers/ManSalon.jfif",
                    UserId = null,
                    CityId = 2,
                    Address = "Zeytinburnu",
                    Rating = 0,
                    RatersCount = 0
                },
                 new Barber
                 {
                     Id = 2,
                     CreatedOn = DateTime.Now,
                     ModifiedOn = DateTime.Now,
                     IsDeleted = false,
                     DeletedOn = DateTime.Now,
                     Name = "Erkek Kuaför 2",
                     ImageUrl = "../images/Barbers/ManSalon.jfif",
                     UserId = null,
                     CityId = 1,
                     Address = "Keçiören",
                     Rating = 0,
                     RatersCount = 0
                 },
                  new Barber
                  {
                      Id = 3,
                      CreatedOn = DateTime.Now,
                      ModifiedOn = DateTime.Now,
                      IsDeleted = false,
                      DeletedOn = DateTime.Now,
                      Name = "Erkek Kuaför 3",
                      ImageUrl = "../images/Barbers/ManSalon.jfif",
                      UserId = null,
                      CityId = 2,
                      Address = "Zeytinburnu",
                      Rating = 0,
                      RatersCount = 0
                  },
                   new Barber
                   {
                       Id = 4,
                       CreatedOn = DateTime.Now,
                       ModifiedOn = DateTime.Now,
                       IsDeleted = false,
                       DeletedOn = DateTime.Now,
                       Name = "Erkek Kuaför 4",
                       ImageUrl = "../images/Barbers/ManSalon.jfif",
                       UserId = null,
                       CityId = 1,
                       Address = "Keçiören",
                       Rating = 0,
                       RatersCount = 0
                   },
                    new Barber
                    {
                        Id = 5,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now,
                        IsDeleted = false,
                        DeletedOn = DateTime.Now,
                        Name = "Erkek Kuaför 5",
                        ImageUrl = "../images/Barbers/ManSalon.jfif",
                        UserId = null,
                        CityId = 2,
                        Address = "Zeytinburnu",
                        Rating = 0,
                        RatersCount = 0
                    },
                     new Barber
                     {
                         Id = 6,
                         CreatedOn = DateTime.Now,
                         ModifiedOn = DateTime.Now,
                         IsDeleted = false,
                         DeletedOn = DateTime.Now,
                         Name = "Erkek Kuaför 6",
                         ImageUrl = "../images/Barbers/ManSalon.jfif",
                         UserId = null,
                         CityId = 1,
                         Address = "Çankaya",
                         Rating = 0,
                         RatersCount = 0
                     },
                      new Barber
                      {
                          Id = 7,
                          CreatedOn = DateTime.Now,
                          ModifiedOn = DateTime.Now,
                          IsDeleted = false,
                          DeletedOn = DateTime.Now,
                          Name = "Erkek Kuaför 7",
                          ImageUrl = "../images/Barbers/ManSalon.jfif",
                          UserId = null,
                          CityId = 2,
                          Address = "Bağcılar",
                          Rating = 0,
                          RatersCount = 0
                      },
                       new Barber
                       {
                           Id = 8,
                           CreatedOn = DateTime.Now,
                           ModifiedOn = DateTime.Now,
                           IsDeleted = false,
                           DeletedOn = DateTime.Now,
                           Name = "Erkek Kuaför 8",
                           ImageUrl = "../images/Barbers/ManSalon.jfif",
                           UserId = null,
                           CityId = 1,
                           Address = "Pursaklar",
                           Rating = 0,
                           RatersCount = 0
                       },
                        new Barber
                        {
                            Id = 9,
                            CreatedOn = DateTime.Now,
                            ModifiedOn = DateTime.Now,
                            IsDeleted = false,
                            DeletedOn = DateTime.Now,
                            Name = "Erkek Kuaför 9",
                            ImageUrl = "../images/Barbers/ManSalon.jfif",
                            UserId = null,
                            CityId = 2,
                            Address = "Bakırköy",
                            Rating = 0,
                            RatersCount = 0
                        },
                         new Barber
                         {
                             Id = 10,
                             CreatedOn = DateTime.Now,
                             ModifiedOn = DateTime.Now,
                             IsDeleted = false,
                             DeletedOn = DateTime.Now,
                             Name = "Erkek Kuaför 10",
                             ImageUrl = "../images/Barbers/ManSalon.jfif",
                             UserId = null,
                             CityId = 1,
                             Address = "Gölbaşı",
                             Rating = 0,
                             RatersCount = 0
                         },
                          new Barber
                          {
                              Id = 11,
                              CreatedOn = DateTime.Now,
                              ModifiedOn = DateTime.Now,
                              IsDeleted = false,
                              DeletedOn = DateTime.Now,
                              Name = "Erkek Kuaför 11",
                              ImageUrl = "../images/Barbers/ManSalon.jfif",
                              UserId = null,
                              CityId = 2,
                              Address = "Fatih",
                              Rating = 0,
                              RatersCount = 0
                          }
                );
        }
    }
}
