using BusinessLayer.Mapping;
using DataAccessLayer.Entities;

namespace BusinessLayer.Models
{
    public class BarberViewModel : IMapperFrom<Barber>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string CityName { get; set; }

        public string Address { get; set; }

        public double Rating { get; set; }

        public int RatersCount { get; set; }

        public int AppointmentsCount { get; set; }
    }
}
