using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CoreLayer.DataAccess.Entities;

namespace DataAccessLayer.Entities
{
    public class SalonService : BaseDeletableModel<int>
    {
        public SalonService()
        {
            Appointments = new HashSet<Appointment>();
        }

        [Required]
        public string SalonId { get; set; }

        public virtual Salon Salon { get; set; }

        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }

       
        public bool Available { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
