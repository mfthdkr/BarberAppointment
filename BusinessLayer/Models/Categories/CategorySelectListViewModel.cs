using BusinessLayer.Mapping;
using DataAccessLayer.Entities;

namespace BusinessLayer.Models.Categories
{
    public class CategorySelectListViewModel : IMapperFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
