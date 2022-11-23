using BusinessLayer.Mapping;
using DataAccessLayer.Entities;

namespace BusinessLayer.Models.Services
{
    public class ServiceViewModel : IMapperFrom<Service>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string CategoryName { get; set; }

        public int SalonsCount { get; set; }

        public int AppointmentsCount { get; set; }
    }
}
