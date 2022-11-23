using BusinessLayer.Mapping;
using DataAccessLayer.Entities;

namespace BusinessLayer.Models.Salons
{
    public class SalonSimpleViewModel : IMapperFrom<Salon>
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
