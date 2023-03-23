using BusinessLayer.Models;
using BusinessLayer.Services.Abstract;
using CoreLayer.MvcUI.Pagination;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class BarbersController : Controller
    {
        private readonly IBarbersService _barberService;

        public BarbersController(IBarbersService barberService)
        {
            _barberService = barberService;
        }

        public async Task<IActionResult> Index(int? pageNumber)
        {
            int pageSize = PageSizesConstants.Salons;
            var pageIndex = pageNumber ?? 1;

            var barbers = await _barberService.GetAllForPaging<BarberViewModel>(pageSize, pageIndex);
            var barbersList = barbers.ToList();

            var count = await _barberService.GetCountForPagination();

            var viewModel = new PaginatedList<BarberViewModel>(barbersList, count, pageIndex, pageSize);
            return View(viewModel);
        }
    }
}
