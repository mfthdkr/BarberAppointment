namespace BusinessLayer.Services.Abstract
{
    public interface IAppointmentsService
    {
        Task<T> GetAppointmentById<T>(int id);
        Task<IEnumerable<T>> GetAllAppointments<T>();
        Task<IEnumerable<T>> GetAllAppointmentsBySalon<T>(int barberId);
        Task<IEnumerable<T>> GetOncomingAppointmentsByUser<T>(string userId);
        Task<IEnumerable<T>> GetPastAppointmentsByUser<T>(string userId);
        Task AddAppointmentAsync(string userId, int barberId, DateTime dateTime);
        Task DeleteAppointmentAsync(int id);

        Task ConfirmAppointmentAsync(int id);

        Task DeclineAppointmentAsync(int id);

        Task RateAppointmentAsync(int id);
    }
}
