using System.Threading.Tasks;
using BusinessLayer.Models.Salons;
using BusinessLayer.Services.Salons;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Areas.Manager.ViewComponents
{
    public class SalonsSimpleListViewComponent : ViewComponent
    {
        private readonly ISalonsService _salonsService;

        public SalonsSimpleListViewComponent(ISalonsService salonsService)
        {
            _salonsService = salonsService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var viewModel = new SalonsSimpleListViewModel
            {
                Salons = await _salonsService.GetAll<SalonSimpleViewModel>(),
            };

            return View(viewModel);
        }
    }
}
