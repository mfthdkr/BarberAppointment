using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Appointments
{
    public interface IAppointmentsService
    {
        Task<IEnumerable<T>> GetUpcomingByUserTest<T>(string userId);


        Task<T> GetById<T>(string id);

        Task<IEnumerable<T>> GetAll<T>();

        Task<IEnumerable<T>> GetAllBySalon<T>(string salonId);

        Task<IEnumerable<T>> GetUpcomingByUser<T>(string userId);

        Task<IEnumerable<T>> GetPastByUser<T>(string userId);

        Task Add(string userId, string salonId, int serviceId, DateTime dateTime);

        Task Delete(string id);

        Task Confirm(string id);

        Task Decline(string id);

        Task RateAppointment(string id);
    }
}
