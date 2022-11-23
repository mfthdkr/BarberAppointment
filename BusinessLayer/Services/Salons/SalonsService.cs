using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoreLayer.DataAccess.Repositories;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services.Salons
{
    public class SalonsService : ISalonsService
    {
        private readonly IGenericRepository<Salon> _salonsRepository;
        private readonly IMapper _mapper;

        public SalonsService(IGenericRepository<Salon> salonsRepository, IMapper mapper)
        {
            _salonsRepository = salonsRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<T>> GetAll<T>()
        {
            var salons =
                await _salonsRepository
                .All()
                .OrderBy(x => x.Name)
                .ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync();
            return salons;
        }

        public async Task<IEnumerable<T>> GetAllForPaging<T>(
            
            int? sortId,
            int pageSize,
            int pageIndex)
        {
            IQueryable<Salon> query =
                _salonsRepository
                .AllAsNoTracking()
                .OrderBy(x => x.Name);

           

            if (sortId != null)
            {
                query = query
                    .Where(x => x.CategoryId == sortId);
            }

            return await query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<int> GetCountForPagination(int? sortId)
        {
            IQueryable<Salon> query =
                _salonsRepository
                .AllAsNoTracking()
                .OrderBy(x => x.Name);


            if (sortId != null)
            {
                query = query
                    .Where(x => x.CategoryId == sortId);
            }

            return await query.CountAsync();
        }

        public async Task<IEnumerable<string>> GetAllIdsByCategory(int categoryId)
        {
            var salonsIds =
                await _salonsRepository
                .All()
                .Where(x => x.CategoryId == categoryId)
                .Select(x => x.Id)
                .ToListAsync();
            return salonsIds;
        }

        public async Task<T> GetById<T>(string id)
        {
            var salon =
                await _salonsRepository
                .All()
                .Where(x => x.Id == id)
                .ProjectTo<T>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
            return salon;
        }

        public async Task<string> Add(string name, int categoryId, int cityId, string address, string imageUrl)
        {
            var salon = new Salon
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                CategoryId = categoryId,
                CityId = cityId,
                Address = address,
                ImageUrl = imageUrl,
                Rating = 0,
                RatersCount = 0,
            };

            await _salonsRepository.AddAsync(salon);
            await _salonsRepository.SaveChangesAsync();
            return salon.Id;
        }

        public async Task Delete(string id)
        {
            var salon =
                await _salonsRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            _salonsRepository.Delete(salon);
            await _salonsRepository.SaveChangesAsync();
        }

        public async Task RateSalon(string id, int rateValue)
        {
            var salon =
                await _salonsRepository
                .All()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            var oldRating = salon.Rating;
            var oldRatersCount = salon.RatersCount;

            var newRatersCount = oldRatersCount + 1;
            var newRating = (oldRating + rateValue) / newRatersCount;

            salon.Rating = newRating;
            salon.RatersCount = newRatersCount;

            await _salonsRepository.SaveChangesAsync();
        }
    }
}
