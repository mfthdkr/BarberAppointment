using BusinessLayer.Models.Cities;
using BusinessLayer.Services.Cities;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Areas.Administration.Controllers
{
    public class CitiesController : AdministrationController
    {
        private readonly ICitiesService _citiesService;

        public CitiesController(ICitiesService citiesService)
        {
            _citiesService = citiesService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new CitiesListViewModel
            {
                Cities = await _citiesService.GetAll<CityViewModel>(),
            };
            return View(viewModel);
        }

        public IActionResult AddCity()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCity(CityInputModel input)
        {
            if (!ModelState.IsValid)
            {
                return View(input);
            }

            await _citiesService.Add(input.Name);

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
