using BusinessLayer.Models;
using BusinessLayer.Services.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    [Authorize]
    public class AppointmentsController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IBarbersService _barberService;
        private readonly IAppointmentsService _appointmentsService;

        public AppointmentsController(UserManager<User> userManager, IBarbersService barberService, IAppointmentsService appointmentsService)
        {
            _userManager = userManager;
            _barberService = barberService;
            _appointmentsService = appointmentsService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var userId = await _userManager.GetUserIdAsync(user);

            var result = await _appointmentsService.GetOncomingAppointmentsByUser<AppointmentViewModel>(userId);

            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> CreateAppointment(int barberId)
        {
            var viewModel = new AppointmentViewModel
            {
                BarberId = barberId
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAppointment(AppointmentViewModel input)
        {
            if (!ModelState.IsValid)
            {
                var  values =  ModelState.Values;
                return RedirectToAction("MakeAnAppointment", new { input.BarberId });
            }

            var user = await _userManager.GetUserAsync(HttpContext.User);
            var userId = await _userManager.GetUserIdAsync(user);

            await _appointmentsService.AddAppointmentAsync(userId, input.BarberId, input.DateTime);

            return RedirectToAction("Index", "Appointments");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteAppointment(int id)
        {
            var viewModel = await _appointmentsService.GetAppointmentById<AppointmentViewModel>(id);

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAppointmentPost(int id)
        {
            await _appointmentsService.DeleteAppointmentAsync(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> RateAppointment(int id)
        {

            var viewModel = await _appointmentsService.GetAppointmentById<AppointmentRateViewModel>(id);

            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> RateAppointment(AppointmentRateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", new { id = model.Id });
            }

            await _appointmentsService.RateAppointmentAsync(model.Id);
            await _barberService.RateSalon(model.BarberId, model.RateValue);

            return RedirectToAction("Index", "Barbers");
        }
    }
}
