using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Categories
{
    public interface ICategoriesService
    {
        Task<IEnumerable<T>> GetAll<T>(int? count = null);

        Task<T> GetById<T>(int id);

        Task Add(string name, string description, string imageUrl);

        Task Delete(int id);
    }
}
