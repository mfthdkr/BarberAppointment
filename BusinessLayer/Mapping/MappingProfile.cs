using AutoMapper;
using BusinessLayer.Models.Appointments;
using BusinessLayer.Models.Categories;
using BusinessLayer.Models.Cities;
using BusinessLayer.Models.Salons;
using BusinessLayer.Models.SalonServices;
using BusinessLayer.Models.Services;
using DataAccessLayer.Entities;

namespace BusinessLayer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Appointment,AppointmentViewModel>();
            CreateMap<Appointment, AppointmentRatingViewModel>();
            CreateMap<Category, CategorySelectListViewModel>();
            CreateMap<Category, CategorySimpleViewModel>();
            CreateMap<Category, CategoryViewModel>();
            CreateMap<City, CitySelectListViewModel>();
            CreateMap<City, CityViewModel>();
            CreateMap<SalonService, SalonServiceViewModel>();
            CreateMap<Salon, SalonSimpleViewModel>();
            CreateMap<Salon, SalonViewModel>();
            CreateMap<Salon, SalonWithServicesViewModel>();
            CreateMap<SalonService, SalonServiceDetailsViewModel>();
            CreateMap<SalonService, SalonServiceSimpleViewModel>();
            CreateMap<Service, ServiceViewModel>();

        }
    }
}
