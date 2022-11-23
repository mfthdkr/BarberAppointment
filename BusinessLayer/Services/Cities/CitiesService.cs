using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoreLayer.DataAccess.Repositories;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services.Cities
{
    public class CitiesService : ICitiesService
    {
        private readonly IGenericRepository<City> _citiesRepository;
        private readonly IMapper _mapper;
        public CitiesService(IGenericRepository<City> citiesRepository, IMapper mapper)
        {
            _citiesRepository = citiesRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<T>> GetAll<T>()
        {
            var cities =
                await _citiesRepository
                .All()
                .OrderBy(x => x.Id)
                .ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync();
            return cities;
        }

        public async Task Add(string name)
        {
            await _citiesRepository.AddAsync(new City
            {
                Name = name,
            });
            await _citiesRepository.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var city =
                await _citiesRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            _citiesRepository.Delete(city);
            await _citiesRepository.SaveChangesAsync();
        }
    }
}
