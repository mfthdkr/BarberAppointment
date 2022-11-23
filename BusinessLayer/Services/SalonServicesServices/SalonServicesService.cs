using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoreLayer.DataAccess.Repositories;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services.SalonServicesServices
{
    public class SalonServicesService : ISalonServicesService
    {
        private readonly IGenericRepository<SalonService> _salonServicesRepository;
        private readonly IMapper _mapper;
        public SalonServicesService(IGenericRepository<SalonService> salonServicesRepository, IMapper mapper)
        {
            _salonServicesRepository = salonServicesRepository;
            _mapper = mapper;
        }

        public async Task<T> GetById<T>(string salonId, int serviceId)
        {
            var salonService =
                await _salonServicesRepository
                .All()
                .Where(x => x.SalonId == salonId && x.ServiceId == serviceId)
                .ProjectTo<T>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
            return salonService;
        }

        public async Task Add(string salonId, IEnumerable<int> servicesIds)
        {
            foreach (var serviceId in servicesIds)
            {
                await _salonServicesRepository.AddAsync(new SalonService
                {
                    SalonId = salonId,
                    ServiceId = serviceId,
                    Available = true,
                });
            }

            await _salonServicesRepository.SaveChangesAsync();
        }

        public async Task Add(IEnumerable<string> salonsIds, int serviceId)
        {
            foreach (var salonId in salonsIds)
            {
                await _salonServicesRepository.AddAsync(new SalonService
                {
                    SalonId = salonId,
                    ServiceId = serviceId,
                    Available = true,
                });
            }

            await _salonServicesRepository.SaveChangesAsync();
        }

        public async Task ChangeAvailableStatus(string salonId, int serviceId)
        {
            var salonService =
                await _salonServicesRepository
                .All()
                .Where(x => x.SalonId == salonId
                            && x.ServiceId == serviceId)
                .FirstOrDefaultAsync();

            salonService.Available = !salonService.Available;

            await _salonServicesRepository.SaveChangesAsync();
        }
    }
}
