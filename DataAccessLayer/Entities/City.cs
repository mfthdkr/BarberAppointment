using CoreLayer.DataAccess.Entities;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class City : BaseDeletableModel<int>
    {
        public City()
        {
            Salons = new HashSet<Salon>();
        }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        public virtual ICollection<Salon> Salons { get; set; }
    }
}
