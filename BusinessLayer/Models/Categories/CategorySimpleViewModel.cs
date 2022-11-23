using BusinessLayer.Mapping;
using DataAccessLayer.Entities;

namespace BusinessLayer.Models.Categories
{
    public class CategorySimpleViewModel : IMapperFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SalonsCount { get; set; }
    }
}
