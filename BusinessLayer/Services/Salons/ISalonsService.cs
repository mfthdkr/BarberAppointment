using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Salons
{
    public interface ISalonsService
    {
        Task<IEnumerable<T>> GetAll<T>();

        Task<IEnumerable<T>> GetAllForPaging<T>(
            
            int? sortId,
            int pageSize,
            int pageIndex);

        Task<int> GetCountForPagination(int? sortId);

        Task<IEnumerable<string>> GetAllIdsByCategory(int categoryId);

        Task<T> GetById<T>(string id);

        Task<string> Add(string name, int categoryId, int cityId, string address, string imageUrl);

        Task Delete(string id);

        Task RateSalon(string id, int rateValue);
    }
}
