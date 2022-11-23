using System;
using System.IO;
using System.Threading.Tasks;
using BusinessLayer.Models.Categories;
using BusinessLayer.Models.Cities;
using BusinessLayer.Models.Salons;
using BusinessLayer.Services.Categories;
using BusinessLayer.Services.Cities;
using BusinessLayer.Services.Salons;
using BusinessLayer.Services.SalonServicesServices;
using BusinessLayer.Services.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcUI.Areas.Administration.Controllers
{
    public class SalonsController : AdministrationController
    {
        private readonly ISalonsService _salonsService;
        private readonly ICategoriesService _categoriesService;
        private readonly ICitiesService _citiesService;
        private readonly IServicesService _servicesService;
        private readonly ISalonServicesService _salonServicesService;
       

        public SalonsController(
            ISalonsService salonsService,
            ICategoriesService categoriesService,
            ICitiesService citiesService,
            IServicesService servicesService,
            ISalonServicesService salonServicesService)
        {
            _salonsService = salonsService;
            _categoriesService = categoriesService;
            _citiesService = citiesService;
            _servicesService = servicesService;
            _salonServicesService = salonServicesService;
            
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new SalonsListViewModel
            {
                Salons = await _salonsService.GetAll<SalonViewModel>(),
            };
            return View(viewModel);
        }

        public async Task<IActionResult> AddSalon()
        {
            var categories = await _categoriesService.GetAll<CategorySelectListViewModel>();
            var cities = await _citiesService.GetAll<CitySelectListViewModel>();

            ViewData["Categories"] = new SelectList(categories, "Id", "Name");
            ViewData["Cities"] = new SelectList(cities, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSalon(SalonInputModel input)
        {
            if (!ModelState.IsValid)
            {
                return View(input);
            }

            var extension = Path.GetExtension(input.Image.FileName);
            var newImageName = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/Salons/", newImageName);
            var stream = new FileStream(location, FileMode.Create);
            await input.Image.CopyToAsync(stream);
            string imageUrl = "../images/Salons/" + newImageName;
            
            // Salonları ekle
            var salonId = await _salonsService.Add(input.Name, input.CategoryId, input.CityId, input.Address, imageUrl);

            // Eklenen salonun kategorisine ait hizmetleri getir.
            // yeni eklenen salonu bütün hizmetlere ekle
            var servicesIds = await _servicesService.GetAllIdsByCategory(input.CategoryId);
            await _salonServicesService.Add(salonId, servicesIds);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteSalon(string id)
        {
            if (id.StartsWith("seeded"))
            {
                return RedirectToAction("Index");
            }

            await _salonsService.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
