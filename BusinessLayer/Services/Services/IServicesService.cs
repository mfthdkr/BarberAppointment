using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Services
{
    public interface IServicesService
    {
        Task<IEnumerable<T>> GetAll<T>();

        Task<IEnumerable<int>> GetAllIdsByCategory(int categoryId);

        Task<int> Add(string name, int categoryId, string description);

        Task Delete(int id);
    }
}
