using BusinessLayer.Mapping;
using DataAccessLayer.Entities;

namespace BusinessLayer.Models.SalonServices
{
    public class SalonServiceSimpleViewModel : IMapperFrom<SalonService>
    {
        public string SalonId { get; set; }

        public int ServiceId { get; set; }

        public bool Available { get; set; }
    }
}
