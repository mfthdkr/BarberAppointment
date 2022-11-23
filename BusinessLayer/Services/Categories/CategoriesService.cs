using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoreLayer.DataAccess.Repositories;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services.Categories
{
    public class CategoriesService : ICategoriesService
    {
        private readonly IGenericRepository<Category> _categoriesRepository;
        private readonly IMapper _mapper;


        public CategoriesService(IGenericRepository<Category> categoriesRepository, IMapper mapper)
        {
            _categoriesRepository = categoriesRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<T>> GetAll<T>(int? count = null)
        {
            IQueryable<Category> query =
                _categoriesRepository
                .All()
                .OrderBy(x => x.Id);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return await query.ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<T> GetById<T>(int id)
        {
            var category =
                await _categoriesRepository
                .All()
                .Where(x => x.Id == id)
                .ProjectTo<T>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
            return category;
        }

        public async Task Add(string name, string description, string imageUrl)
        {
            await _categoriesRepository.AddAsync(new Category
            {
                Name = name,
                Description = description,
                ImageUrl = imageUrl,
            });
            await _categoriesRepository.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var category =
                await _categoriesRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            _categoriesRepository.Delete(category);
            await _categoriesRepository.SaveChangesAsync();
        }
    }
}
