using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLayer.Services.Abstract;
using CoreLayer.DataAccess.Repositories;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services.Concrete
{
    public class CitiesManager : ICitiesService
    {
        private readonly IRepositoryBase<City> _citiesRepository;
        private readonly IMapper _mapper;

        public CitiesManager(IRepositoryBase<City> citiesRepository, IMapper mapper)
        {
            _citiesRepository = citiesRepository;
            _mapper = mapper;
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
                .GetAllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            _citiesRepository.Delete(city);
            await _citiesRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll<T>()
        {
            var cities =
                await _citiesRepository
                .GetAll()
                .OrderBy(x => x.Id)
                .ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync();
            return cities;
        }
    }
}
