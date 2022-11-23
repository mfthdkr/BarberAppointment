using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.Services.SalonServicesServices
{
    public interface ISalonServicesService
    {
        Task<T> GetById<T>(string salonId, int serviceId);

        Task Add(string salonId, IEnumerable<int> servicesIds);

        Task Add(IEnumerable<string> salonsIds, int serviceId);

        Task ChangeAvailableStatus(string salonId, int serviceId);
    }
}
