using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataAccessLayer.Configurations
{
    public class SalonServiceConfiguration : IEntityTypeConfiguration<SalonService>
    {
        public void Configure(EntityTypeBuilder<SalonService> builder)
        {
            builder.HasKey(ss => new { ss.SalonId, ss.ServiceId });

            builder.HasData(
                new SalonService
                {
                    SalonId= "salon1",
                    ServiceId= 1,
                    Id=0,
                    CreatedOn= DateTime.Now,
                    ModifiedOn=DateTime.Now,
                    IsDeleted=false,
                    DeletedOn=DateTime.Now,
                    Available=true,
                },
                new SalonService
                {
                    SalonId = "salon1",
                    ServiceId = 2,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon2",
                    ServiceId = 1,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon2",
                    ServiceId = 2,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon3",
                    ServiceId = 1,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon3",
                    ServiceId = 2,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon4",
                    ServiceId = 1,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon4",
                    ServiceId = 2,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon5",
                    ServiceId = 1,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon5",
                    ServiceId = 2,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },




                new SalonService
                {
                    SalonId = "salon6",
                    ServiceId = 3,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon6",
                    ServiceId = 4,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon6",
                    ServiceId = 5,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon6",
                    ServiceId = 6,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon6",
                    ServiceId = 7,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon6",
                    ServiceId = 8,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon6",
                    ServiceId = 9,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon6",
                    ServiceId = 10,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon6",
                    ServiceId = 11,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },



                new SalonService
                {
                    SalonId = "salon7",
                    ServiceId = 3,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon7",
                    ServiceId = 4,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon7",
                    ServiceId = 5,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon7",
                    ServiceId = 6,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon7",
                    ServiceId = 7,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon7",
                    ServiceId = 8,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon7",
                    ServiceId = 9,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon7",
                    ServiceId = 10,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon7",
                    ServiceId = 11,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },




                new SalonService
                {
                    SalonId = "salon8",
                    ServiceId = 3,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon8",
                    ServiceId = 4,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon8",
                    ServiceId = 5,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon8",
                    ServiceId = 6,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon8",
                    ServiceId = 7,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon8",
                    ServiceId = 8,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon8",
                    ServiceId = 9,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon8",
                    ServiceId = 10,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon8",
                    ServiceId = 11,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },





                new SalonService
                {
                    SalonId = "salon9",
                    ServiceId = 3,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon9",
                    ServiceId = 4,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon9",
                    ServiceId = 5,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon9",
                    ServiceId = 6,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon9",
                    ServiceId = 7,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon9",
                    ServiceId = 8,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon9",
                    ServiceId = 9,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon9",
                    ServiceId = 10,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon9",
                    ServiceId = 11,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },


                new SalonService
                {
                    SalonId = "salon10",
                    ServiceId = 3,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon10",
                    ServiceId = 4,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon10",
                    ServiceId = 5,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon10",
                    ServiceId = 6,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon10",
                    ServiceId = 7,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon10",
                    ServiceId = 8,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon10",
                    ServiceId = 9,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon10",
                    ServiceId = 10,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon10",
                    ServiceId = 11,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },





                new SalonService
                {
                    SalonId = "salon11",
                    ServiceId = 3,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon11",
                    ServiceId = 4,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon11",
                    ServiceId = 5,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon11",
                    ServiceId = 6,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon11",
                    ServiceId = 7,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon11",
                    ServiceId = 8,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon11",
                    ServiceId = 9,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon11",
                    ServiceId = 10,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                },
                new SalonService
                {
                    SalonId = "salon11",
                    ServiceId = 11,
                    Id = 0,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    DeletedOn = DateTime.Now,
                    Available = true,
                }
                );
        }
    }
}
