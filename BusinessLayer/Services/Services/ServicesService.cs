using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoreLayer.DataAccess.Repositories;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services.Services
{
    public class ServicesService : IServicesService
    {
        private readonly IGenericRepository<Service> _servicesRepository;
        private readonly IMapper _mapper;

        public ServicesService(IGenericRepository<Service> servicesRepository, IMapper mapper)
        {
            _servicesRepository = servicesRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<T>> GetAll<T>()
        {
            var services =
                await _servicesRepository
                .All()
                .OrderBy(x => x.CategoryId)
                .ThenBy(x => x.Id)
                .ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync();
            return services;
        }

        public async Task<IEnumerable<int>> GetAllIdsByCategory(int categoryId)
        {
            ICollection<int> servicesIds =
                await _servicesRepository
                .All()
                .Where(x => x.CategoryId == categoryId)
                .OrderBy(x => x.Id)
                .Select(x => x.Id)
                .ToListAsync();
            return servicesIds;
        }

        public async Task<int> Add(string name, int categoryId, string description)
        {
            var service = new Service
            {
                Name = name,
                CategoryId = categoryId,
                Description = description,
            };
            await _servicesRepository.AddAsync(service);
            await _servicesRepository.SaveChangesAsync();
            return service.Id;
        }

        public async Task Delete(int id)
        {
            var service =
                await _servicesRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            _servicesRepository.Delete(service);
            await _servicesRepository.SaveChangesAsync();
        }
    }
}
