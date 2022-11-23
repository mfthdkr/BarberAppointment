using CoreLayer.DataAccess.Entities;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Service : BaseDeletableModel<int>
    {
        public Service()
        {
            Salons = new HashSet<SalonService>();
            Appointments = new HashSet<Appointment>();
        }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [Required]
        [MaxLength(700)]
        public string Description { get; set; }

        public virtual ICollection<SalonService> Salons { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
