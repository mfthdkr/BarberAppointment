using System.Threading.Tasks;
using BusinessLayer.Models.Categories;
using BusinessLayer.Services.Categories;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.ViewComponents
{
    public class CategoriesSimpleListViewComponent : ViewComponent
    {
        private readonly ICategoriesService _categoriesService;

        public CategoriesSimpleListViewComponent(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var viewModel = new CategoriesSimpleListViewModel
            {
                Categories = await _categoriesService.GetAll<CategorySimpleViewModel>(),
            };

            return View(viewModel);
        }
    }
}
