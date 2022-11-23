using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Models.Categories;
using BusinessLayer.Models.Salons;
using BusinessLayer.Services.Categories;
using BusinessLayer.Services.Salons;
using CoreLayer.MvcUI.Pagination;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class SalonsController : BaseController
    {
        private readonly ISalonsService _salonsService;
        private readonly ICategoriesService _categoriesService;

        public SalonsController(
            ISalonsService salonsService,
            ICategoriesService categoriesService)
        {
            _salonsService = salonsService;
            _categoriesService = categoriesService;
        }

        public async Task<IActionResult> Index(
            int? sortId, // categoryId
            int? pageNumber)
        {
            if (sortId != null)
            {
                var category = await _categoriesService
                    .GetById<CategorySimpleViewModel>(sortId.Value);
                if (category == null)
                {
                    return new StatusCodeResult(404);
                }

                ViewData["CategoryName"] = category.Name;
            }

            ViewData["CurrentSort"] = sortId;
            
            int pageSize = PageSizesConstants.Salons;
            var pageIndex = pageNumber ?? 1;

            var salons = await _salonsService
                .GetAllForPaging<SalonViewModel>(
                     sortId, pageSize, pageIndex);
            var salonsList = salons.ToList();

            var count = await _salonsService
                .GetCountForPagination(sortId);

            var viewModel = new SalonsPaginatedListViewModel
            {
                Salons = new PaginatedList<SalonViewModel>(salonsList, count, pageIndex, pageSize),
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Details(string id)
        {
            var viewModel = await _salonsService.GetById<SalonWithServicesViewModel>(id);
           
            if (viewModel == null)
            {
                return new StatusCodeResult(404);
            }

            return View(viewModel);
        }
    }
}
