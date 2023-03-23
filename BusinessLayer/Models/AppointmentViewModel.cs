using BusinessLayer.Mapping;
using DataAccessLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Models
{
    public class AppointmentViewModel : IMapperFrom<Appointment>
    {
        public int Id { get; set; }
        [Required]
        public DateTime DateTime { get; set; }

        public string? UserEmail { get; set; }
        [Required]
        public int BarberId { get; set; }

        public string? BarberName { get; set; }
        public string? BarberCityName { get; set; }

        public string? BarberAddress { get; set; }
        public bool? Confirmed { get; set; }

        public bool? IsSalonRatedByTheUser { get; set; }
    }
}
