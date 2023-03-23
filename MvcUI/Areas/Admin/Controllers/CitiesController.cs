using BusinessLayer.Models;
using BusinessLayer.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Administrator")]
    [Area("Admin")]
    public class CitiesController : Controller
    {
        private readonly ICitiesService _citiesService;

        public CitiesController(ICitiesService citiesService)
        {
            _citiesService = citiesService;
        }
        public async Task<IActionResult> Index()
        {   
            var model = await _citiesService.GetAll<CityViewModel>();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddCity()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCity(CityViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _citiesService.Add(model.Name);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCity(int id)
        {
            if (id <= 2)
            {
                return RedirectToAction("Index");
            }

            await _citiesService.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
