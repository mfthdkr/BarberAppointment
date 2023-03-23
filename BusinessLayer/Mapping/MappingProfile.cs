using AutoMapper;
using BusinessLayer.Models;
using DataAccessLayer.Entities;

namespace BusinessLayer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Barber,BarberViewModel>();
            CreateMap<Appointment, AppointmentViewModel>();
            CreateMap<Appointment, AppointmentRateViewModel>();
            CreateMap<City, CityViewModel>();
            CreateMap<City, CitySelectListViewModel>();
        }
    }
}
