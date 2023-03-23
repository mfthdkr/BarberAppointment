using CoreLayer.DataAccess.Entities;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Barber :BaseEntity
    {
        public Barber()
        {
            Appointments = new HashSet<Appointment>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public string? UserId { get; set; }

        public virtual User User { get; set; }

        public int CityId { get; set; }

        public virtual City City { get; set; }

        [Required]
        public string Address { get; set; }

        public double Rating { get; set; }

        public int RatersCount { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
