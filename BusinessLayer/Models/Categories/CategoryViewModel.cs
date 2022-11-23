using BusinessLayer.Mapping;
using DataAccessLayer.Entities;

namespace BusinessLayer.Models.Categories
{
    public class CategoryViewModel : IMapperFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int SalonsCount { get; set; }

        public int ServicesCount { get; set; }
    }
}
