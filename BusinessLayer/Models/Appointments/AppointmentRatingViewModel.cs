using BusinessLayer.Mapping;
using DataAccessLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Models.Appointments
{
    public class AppointmentRatingViewModel : IMapperFrom<Appointment>
    {
        public string Id { get; set; }

        public string SalonId { get; set; }

        public string SalonName { get; set; }

        public string SalonCategoryName { get; set; }

        public string SalonCityName { get; set; }

        public string SalonAddress { get; set; }

        public string SalonImageUrl { get; set; }

        public bool? IsSalonRatedByTheUser { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "1 - 5 arasında puanlayın.")]
        public int RateValue { get; set; }
    }
}
