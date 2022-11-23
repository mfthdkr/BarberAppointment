using System.Threading.Tasks;
using BusinessLayer.Models.Appointments;
using BusinessLayer.Services.Appointments;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Areas.Administration.Controllers
{
    public class AppointmentsController : AdministrationController
    {
        private readonly IAppointmentsService _appointmentsService;

        public AppointmentsController(IAppointmentsService appointmentsService)
        {
            _appointmentsService = appointmentsService;
        }

        public async Task<IActionResult> Index()
        {
            
            var result = await _appointmentsService.GetAll<AppointmentViewModel>();

            return View(result);
        }
    }
}
