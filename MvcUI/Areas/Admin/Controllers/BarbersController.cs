using BusinessLayer.Models;
using BusinessLayer.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Administrator")]
    [Area("Admin")]
    public class BarbersController : Controller
    {
        private readonly ICitiesService _citiesService;
        private readonly IBarbersService _barberService;
        private readonly IAppointmentsService _appointmentsService;

        public BarbersController(ICitiesService citiesService, IBarbersService barberService, IAppointmentsService appointmentsService)
        {
            _citiesService = citiesService;
            _barberService = barberService;
            _appointmentsService = appointmentsService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = await _barberService.GetAll<BarberViewModel>();
            return View(viewModel);
        }

        public async Task<IActionResult> AddBarber()
        {
            
            var cities = await _citiesService.GetAll<CitySelectListViewModel>();
            
            ViewData["Cities"] = new SelectList(cities, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBarber(BarberInputViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var extension = Path.GetExtension(model.Image.FileName);
            var newImageName = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/Barbers/", newImageName);
            var stream = new FileStream(location, FileMode.Create);
            await model.Image.CopyToAsync(stream);
            string imageUrl = "../images/Barbers/" + newImageName;
            
            await _barberService.Add(model.Name, model.CityId, model.Address, imageUrl);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteBarber(int id)
        {
            
            await _barberService.Delete(id);

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Details(int id)
        {
            var viewModel = await _barberService.GetById<BarberViewModel>(id);
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmAppointment(int id, int barberId)
        {
            await _appointmentsService.ConfirmAppointmentAsync(id);
            return RedirectToAction("Details", new { id = barberId });
        }

        [HttpPost]
        public async Task<IActionResult> CancelAppointment(int id, int barberId)
        {
            await _appointmentsService.DeclineAppointmentAsync(id);
            return RedirectToAction("Details", new { id = barberId });
        }
    }
}
