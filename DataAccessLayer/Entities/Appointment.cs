using CoreLayer.DataAccess.Entities;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Appointment : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateTime { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual User User { get; set; }

        [Required]
        public int BarberId { get; set; }

        public virtual Barber Barber { get; set; }

        public bool? Confirmed { get; set; }

        public bool? IsSalonRatedByTheUser { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
