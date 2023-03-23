using CoreLayer.DataAccess.Entities;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class City : BaseEntity
    {
        public City()
        {
            Barbers = new HashSet<Barber>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Barber> Barbers { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
