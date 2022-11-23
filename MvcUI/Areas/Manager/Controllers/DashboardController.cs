
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Areas.Manager.Controllers
{
    public class DashboardController : ManagerBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
