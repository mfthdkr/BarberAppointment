using System.Threading.Tasks;
using BusinessLayer.Models.SalonServices;
using BusinessLayer.Services.SalonServicesServices;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.ViewComponents
{
    public class SalonServiceDetailsViewComponent : ViewComponent
    {
        private readonly ISalonServicesService _salonServicesService;

        public SalonServiceDetailsViewComponent(ISalonServicesService salonServicesService)
        {
            _salonServicesService = salonServicesService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string salonId, int serviceId)
        {
            var viewModel =
                await _salonServicesService.GetById<SalonServiceDetailsViewModel>(salonId, serviceId);

            return View(viewModel);
        }
    }
}
