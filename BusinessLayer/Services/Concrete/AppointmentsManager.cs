using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLayer.Services.Abstract;
using CoreLayer.DataAccess.Repositories;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services.Concrete
{
    public class AppointmentsManager : IAppointmentsService
    {
        private readonly IRepositoryBase<Appointment> _appointmentsRepository;
        private readonly IMapper _mapper;

        public AppointmentsManager(IRepositoryBase<Appointment> appointmentsRepository, IMapper mapper)
        {
            _appointmentsRepository = appointmentsRepository;
            _mapper = mapper;
        }

        public async Task AddAppointmentAsync(string userId, int barberId, DateTime dateTime)
        {
            await _appointmentsRepository.AddAsync(new Appointment
            {
                DateTime = dateTime,
                UserId = userId,
                BarberId = barberId,
            });
            await _appointmentsRepository.SaveChangesAsync();
        }

        public async Task ConfirmAppointmentAsync(int id)
        {
            var appointment =
                 await _appointmentsRepository
                 .GetAll()
                 .Where(x => x.Id == id)
                 .FirstOrDefaultAsync();
            appointment.Confirmed = true;
            await _appointmentsRepository.SaveChangesAsync();
        }

        public async Task DeclineAppointmentAsync(int id)
        {
            var appointment =
                await _appointmentsRepository
                .GetAll()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            appointment.Confirmed = false;
            await _appointmentsRepository.SaveChangesAsync();
        }

        public async Task DeleteAppointmentAsync(int id)
        {
            var appointment =
                await _appointmentsRepository
                .GetAllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            _appointmentsRepository.Delete(appointment);
            await _appointmentsRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAppointments<T>()
        {
            var appointments =
                await _appointmentsRepository
                .GetAll()
                .OrderByDescending(x => x.DateTime)
                .ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync();
            return appointments;
        }

        public async Task<IEnumerable<T>> GetAllAppointmentsBySalon<T>(int barberId)
        {
            var appointments =
                await _appointmentsRepository
                .GetAll()
                .Where(x => x.BarberId == barberId)
                .OrderByDescending(x => x.DateTime)
                .ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync();
            return appointments;
        }

        public async Task<T> GetAppointmentById<T>(int id)
        {
            var appointment =
                 await _appointmentsRepository
                 .GetAll()
                 .Where(x => x.Id == id)
                 .ProjectTo<T>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
            return appointment;
        }

        public async Task<IEnumerable<T>> GetOncomingAppointmentsByUser<T>(string userId)
        {
            var appointments =
                await _appointmentsRepository
                .GetAll()
                .Where(x => x.UserId == userId && x.DateTime.Date > DateTime.UtcNow.Date)
                .OrderBy(x => x.DateTime)
                .ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync();
            return appointments;
        }

        public async Task<IEnumerable<T>> GetPastAppointmentsByUser<T>(string userId)
        {
            var appointments =
                await _appointmentsRepository
                .GetAll()
                .Where(x => x.UserId == userId
                        && x.DateTime.Date < DateTime.UtcNow.Date
                        )
                .OrderBy(x => x.DateTime)
                .ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync();
            return appointments;
        }

        public async Task RateAppointmentAsync(int id)
        {
            var appointment =
                await _appointmentsRepository
                .GetAll()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            appointment.IsSalonRatedByTheUser = true;
            await _appointmentsRepository.SaveChangesAsync();
        }
    }
}
