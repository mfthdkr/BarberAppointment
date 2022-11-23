using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Models.Appointments
{
    public class AppointmentInputModel
    {
        [Required]
        public string SalonId { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [Required]

        public DateTime DateTime { get; set; }

    }
}
