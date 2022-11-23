using System.Threading.Tasks;
using BusinessLayer.Models.Salons;
using BusinessLayer.Services.Appointments;
using BusinessLayer.Services.Salons;
using BusinessLayer.Services.SalonServicesServices;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Areas.Manager.Controllers
{
    public class SalonsController : ManagerBaseController
    {
        private readonly ISalonsService _salonsService;
        private readonly ISalonServicesService _salonServicesService;
        private readonly IAppointmentsService _appointmentsService;

        public SalonsController(
            ISalonsService salonsService,
            ISalonServicesService salonServicesService,
            IAppointmentsService appointmentsService)
        {
            _salonsService = salonsService;
            _salonServicesService = salonServicesService;
            _appointmentsService = appointmentsService;
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

        [HttpPost]
        public async Task<IActionResult> ChangeServiceAvailableStatus(string salonId, int serviceId)
        {
            await _salonServicesService.ChangeAvailableStatus(salonId, serviceId);

            return RedirectToAction("Details", new { id = salonId });
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmAppointment(string id, string salonId)
        {
            await _appointmentsService.Confirm(id);
            return RedirectToAction("Details", new { id = salonId });
        }

        [HttpPost]
        public async Task<IActionResult> CancelAppointment(string id, string salonId)
        {
            await _appointmentsService.Decline(id);
            return RedirectToAction("Details", new { id = salonId });
        }

    }
}
