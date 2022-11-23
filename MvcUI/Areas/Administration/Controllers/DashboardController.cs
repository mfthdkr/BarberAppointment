using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Areas.Administration.Controllers
{
    public class DashboardController : AdministrationController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
