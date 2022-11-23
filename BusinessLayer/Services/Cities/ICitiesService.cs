using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Cities
{
    public interface ICitiesService
    {
        Task<IEnumerable<T>> GetAll<T>();

        Task Add(string name);

        Task Delete(int id);
    }
}
