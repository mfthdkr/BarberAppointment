using BusinessLayer.Mapping;
using DataAccessLayer.Entities;

namespace BusinessLayer.Models.Cities
{
    public class CitySelectListViewModel : IMapperFrom<City>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
