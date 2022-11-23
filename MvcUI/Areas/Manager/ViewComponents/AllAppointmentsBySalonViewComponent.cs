using System.Threading.Tasks;
using BusinessLayer.Models.Appointments;
using BusinessLayer.Services.Appointments;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Areas.Manager.ViewComponents
{
    public class AllAppointmentsBySalonViewComponent : ViewComponent
    {
        private readonly IAppointmentsService _appointmentsService;

        public AllAppointmentsBySalonViewComponent(IAppointmentsService appointmentsService)
        {
            _appointmentsService = appointmentsService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string salonId)
        {
            
            var listAppointmentViewModel = await _appointmentsService.GetAllBySalon<AppointmentViewModel>(salonId);

            return View(listAppointmentViewModel);
        }
    }
}
