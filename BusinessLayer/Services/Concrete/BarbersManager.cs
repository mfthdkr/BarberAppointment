using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLayer.Services.Abstract;
using CoreLayer.DataAccess.Repositories;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BusinessLayer.Services.Concrete
{
    public class BarbersManager : IBarbersService
    {
        private readonly IRepositoryBase<Barber> _barberRepository;
        private readonly IMapper _mapper;

        public BarbersManager(IRepositoryBase<Barber> barberRepository, IMapper mapper)
        {
            _barberRepository = barberRepository;
            _mapper = mapper;
        }

        public async Task Add(string name, int cityId, string address, string imageUrl)
        {
            var barber = new Barber()
            {
                Name = name,
                CityId = cityId,
                Address = address,
                ImageUrl = imageUrl,
                Rating = 0,
                RatersCount = 0,
            };
            await _barberRepository.AddAsync(barber);
            await _barberRepository.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            var barber = await _barberRepository.GetAllAsNoTracking().Where(b => b.Id == id).FirstOrDefaultAsync();
            _barberRepository.Delete(barber);
            await _barberRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll<T>()
        {
            var barbers = await _barberRepository.GetAll().OrderBy(b => b.Name).ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync();
            return barbers;
        }

        public async Task<IEnumerable<T>> GetAllForPaging<T>(int pageSize, int pageIndex)
        {
            IQueryable<Barber> queryBarber = _barberRepository.GetAllAsNoTracking().OrderBy(b => b.Id);

            return await queryBarber.Skip((pageIndex - 1) * pageSize).Take(pageSize).ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<T> GetById<T>(int id)
        {
            var barber = await _barberRepository.GetAll().Where(b => b.Id == id).ProjectTo<T>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
            return barber;
        }

        public async Task<int> GetCountForPagination()
        {
            IQueryable<Barber> queryBarber =
                _barberRepository
                .GetAllAsNoTracking()
                .OrderBy(x => x.Name);

            return await queryBarber.CountAsync();
        }

        public async Task RateSalon(int id, int rateValue)
        {
            var barber = await _barberRepository.GetAll().Where(b => b.Id == id).FirstOrDefaultAsync();

            var oldRating = barber.Rating;
            var oldRatersCount = barber.RatersCount;

            var newRatersCount = oldRatersCount + 1;
            var newRating = (oldRating + rateValue) / newRatersCount;

            barber.Rating = newRating;
            barber.RatersCount = newRatersCount;

            await _barberRepository.SaveChangesAsync();
        }
    }
}
