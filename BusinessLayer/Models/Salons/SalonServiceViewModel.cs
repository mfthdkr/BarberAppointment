using BusinessLayer.Mapping;
using DataAccessLayer.Entities;

namespace BusinessLayer.Models.Salons
{
    public class SalonServiceViewModel : IMapperFrom<SalonService>
    {
        public string SalonId { get; set; }

        public int ServiceId { get; set; }

        public string ServiceName { get; set; }

        public string ServiceDescription { get; set; }

        public bool Available { get; set; }
    }
}
