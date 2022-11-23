using System.Diagnostics;

using BusinessLayer.Models;

using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class HomeController : BaseController
    {
        public  IActionResult Index()
        {
           
            return View();
        }



        [Route("/Home/Error/404")]
        public IActionResult Error404()
        {
            return View();
        }

        [Route("/Home/Error/{code:int}")]
        public IActionResult Error(int code)
        {
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
