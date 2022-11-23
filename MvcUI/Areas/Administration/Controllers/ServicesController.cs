using System.Threading.Tasks;
using BusinessLayer.Models.Categories;
using BusinessLayer.Models.Services;
using BusinessLayer.Services.Categories;
using BusinessLayer.Services.Salons;
using BusinessLayer.Services.SalonServicesServices;
using BusinessLayer.Services.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcUI.Areas.Administration.Controllers
{
    public class ServicesController : AdministrationController
    {
        private readonly IServicesService _servicesService;
        private readonly ICategoriesService _categoriesService;
        private readonly ISalonsService _salonsService;
        private readonly ISalonServicesService _salonServicesService;

        public ServicesController(
            IServicesService servicesService,
            ICategoriesService categoriesService,
            ISalonsService salonsService,
            ISalonServicesService salonServicesService)
        {
            _servicesService = servicesService;
            _categoriesService = categoriesService;
            _salonsService = salonsService;
            _salonServicesService = salonServicesService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new ServicesListViewModel
            {
                Services = await _servicesService.GetAll<ServiceViewModel>(),
            };
            return View(viewModel);
        }

        public async Task<IActionResult> AddService()
        {
            var categories = await _categoriesService.GetAll<CategorySelectListViewModel>();
            ViewData["Categories"] = new SelectList(categories, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddService(ServiceInputModel input)
        {
            if (!ModelState.IsValid)
            {
                return View(input);
            }

            // Service tablosuna ekle
            var serviceId = await _servicesService.Add(input.Name, input.CategoryId, input.Description);

            // Eklenen hizmetin kategorisie ait salonları getir
            // yeni hizmeti bütün salonlara ekle
            var salonsIds = await _salonsService.GetAllIdsByCategory(input.CategoryId);
            await _salonServicesService.Add(salonsIds, serviceId);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteService(int id)
        {

            await _servicesService.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
