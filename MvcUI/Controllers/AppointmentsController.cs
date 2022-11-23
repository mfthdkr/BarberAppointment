using BusinessLayer.Models.Appointments;
using BusinessLayer.Models.SalonServices;
using BusinessLayer.Services.Appointments;
using BusinessLayer.Services.Salons;
using BusinessLayer.Services.SalonServicesServices;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MvcUI.Controllers
{
    [Authorize]
    public class AppointmentsController : BaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ISalonsService _salonsService;
        private readonly IAppointmentsService _appointmentsService;
        private readonly ISalonServicesService _salonServicesService;

        // userId ctor'da
        public AppointmentsController(
            UserManager<ApplicationUser> userManager,
            IAppointmentsService appointmentsService,
            ISalonServicesService salonServicesService,
            ISalonsService salonsService)
        {
            _userManager = userManager;
            _appointmentsService = appointmentsService;
            _salonServicesService = salonServicesService;
            
            _salonsService = salonsService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var userId = await _userManager.GetUserIdAsync(user);

            var result = await _appointmentsService.GetUpcomingByUser<AppointmentViewModel>(userId);

            return View(result);
        }

        public async Task<IActionResult> MakeAnAppointment(string salonId, int serviceId)
        {
            var salonService = await _salonServicesService.GetById<SalonServiceSimpleViewModel>(salonId, serviceId);
            if (salonService == null || !salonService.Available)
            {
                return View("UnavailableService");
            }

            var viewModel = new AppointmentInputModel
            {
                SalonId = salonId,
                ServiceId = serviceId,
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> MakeAnAppointment(AppointmentInputModel input)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("MakeAnAppointment", new { input.SalonId, input.ServiceId });
            }

            var user = await _userManager.GetUserAsync(HttpContext.User);
            var userId = await _userManager.GetUserIdAsync(user);

            await _appointmentsService.Add(userId, input.SalonId, input.ServiceId, input.DateTime);

            return RedirectToAction("Index", "Appointments");
        }

        [HttpGet]
        public async Task<IActionResult> CancelAppointment(string id)
        {
            var viewModel = await _appointmentsService.GetById<AppointmentViewModel>(id);
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAppointment(string id)
        {
            await _appointmentsService.Delete(id);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> RatePastAppointment(string id)
        {

            var viewModel = await _appointmentsService.GetById<AppointmentRatingViewModel>(id);

            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> RatePastAppointment(AppointmentRatingViewModel rating)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", new { id = rating.Id });
            }

            if (rating.IsSalonRatedByTheUser == true)
            {
                return RedirectToAction("Index", new { id = rating.Id });
            }

            await _appointmentsService.RateAppointment(rating.Id);
            await _salonsService.RateSalon(rating.SalonId, rating.RateValue);

            return RedirectToAction("Details", "Salons", new { id = rating.SalonId });
        }
    }
}
