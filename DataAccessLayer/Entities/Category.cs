using CoreLayer.DataAccess.Entities;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            Services = new HashSet<Service>();
            Salons = new HashSet<Salon>();
        }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        [MaxLength(700)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        public virtual ICollection<Salon> Salons { get; set; }
    }
}
