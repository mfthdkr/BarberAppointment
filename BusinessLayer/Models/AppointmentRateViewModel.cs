using BusinessLayer.Mapping;
using DataAccessLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Models
{
    public class AppointmentRateViewModel : IMapperFrom<Appointment>
    {
        public int Id { get; set; }

        public int BarberId { get; set; }

        public string? BarberName { get; set; }

        public string? BarberCityName { get; set; }

        public string? BarberAddress { get; set; }

        public string? BarberImageUrl { get; set; }

        public bool? IsSalonRatedByTheUser { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "1 - 5 arasında puanlayın.")]
        public int RateValue { get; set; }
    }
}
