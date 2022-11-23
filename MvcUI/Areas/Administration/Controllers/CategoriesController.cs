using BusinessLayer.Models.Categories;
using BusinessLayer.Services.Categories;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Areas.Administration.Controllers
{
    public class CategoriesController : AdministrationController
    {
        private readonly ICategoriesService _categoriesService;
        public CategoriesController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new CategoriesListViewModel
            {
                Categories = await _categoriesService.GetAll<CategoryViewModel>(),
            };

            return View(viewModel);
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryInputModel input)
        {
            if (!ModelState.IsValid)
            {
                return View(input);
            }

            var extension = Path.GetExtension(input.Image.FileName);
            var newImageName= Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/Categories/", newImageName);
            var stream = new FileStream(location, FileMode.Create);
            await input.Image.CopyToAsync(stream);
            string imageUrl = "../images/Categories/" + newImageName ;
            
            await _categoriesService.Add(input.Name, input.Description, imageUrl);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            if (id <= 2)
            {
                return RedirectToAction("Index");
            }

            await _categoriesService.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
