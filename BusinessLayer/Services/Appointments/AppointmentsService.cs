  using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoreLayer.DataAccess.Repositories;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services.Appointments
{
    public class AppointmentsService : IAppointmentsService
    {
        private readonly IGenericRepository<Appointment> _appointmentsRepository;
        private readonly IMapper _mapper;
        

        public AppointmentsService(IGenericRepository<Appointment> appointmentsRepository, IMapper mapper)
        {
            _appointmentsRepository = appointmentsRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<T>> GetUpcomingByUserTest<T>(string userId)
        {
            var appointments =
                await _appointmentsRepository
                    .All()
                    .Where(x => x.UserId == userId && x.DateTime.Date > DateTime.UtcNow.Date)
                    .OrderBy(x => x.DateTime)
                    .ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync();
            return appointments;
        }

        public async Task<T> GetById<T>(string id)
        {
            var appointment =
                await _appointmentsRepository
                .All()
                .Where(x => x.Id == id)
                .ProjectTo<T>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
            return appointment;
        }

        public async Task<IEnumerable<T>> GetAll<T>()
        {
            var appointments =
                await _appointmentsRepository
                .All()
                .OrderByDescending(x => x.DateTime)
                .ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync();
            return appointments;
        }

        public async Task<IEnumerable<T>> GetAllBySalon<T>(string salonId)
        {
            var appointments =
                await _appointmentsRepository
                .All()
                .Where(x => x.SalonId == salonId)
                .OrderByDescending(x => x.DateTime)
                .ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync();
            return appointments;
        }
       
        public async Task<IEnumerable<T>> GetUpcomingByUser<T>(string userId)
        {
            var appointments =
                await _appointmentsRepository
                .All()
                .Where(x => x.UserId == userId && x.DateTime.Date > DateTime.UtcNow.Date)
                .OrderBy(x => x.DateTime)
                .ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync();
            return appointments;
        }

        public async Task<IEnumerable<T>> GetPastByUser<T>(string userId)
        {
            var appointments =
                await _appointmentsRepository
                .All()
                .Where(x => x.UserId == userId
                        && x.DateTime.Date < DateTime.UtcNow.Date
                        )
                .OrderBy(x => x.DateTime)
                .ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync();
            return appointments;
        }

        public async Task Add(string userId, string salonId, int serviceId, DateTime dateTime)
        {
            await _appointmentsRepository.AddAsync(new Appointment
            {
                Id = Guid.NewGuid().ToString(),
                DateTime = dateTime,
                UserId = userId,
                SalonId = salonId,
                ServiceId = serviceId,
            });
            await _appointmentsRepository.SaveChangesAsync();
        }

        public async Task Delete(string id)
        {
            var appointment =
                await _appointmentsRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            _appointmentsRepository.Delete(appointment);
            await _appointmentsRepository.SaveChangesAsync();
        }

        public async Task Confirm(string id)
        {
            var appointment =
                await _appointmentsRepository
                .All()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            appointment.Confirmed = true;
            await _appointmentsRepository.SaveChangesAsync();
        }

        public async Task Decline(string id)
        {
            var appointment =
                await _appointmentsRepository
                .All()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            appointment.Confirmed = false;
            await _appointmentsRepository.SaveChangesAsync();
        }

        public async Task RateAppointment(string id)
        {
            var appointment =
                await _appointmentsRepository
                .All()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            appointment.IsSalonRatedByTheUser = true;
            await _appointmentsRepository.SaveChangesAsync();
        }
    }
}
