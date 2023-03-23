using BusinessLayer.Models;
using BusinessLayer.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Areas.Admin.ViewComponents
{
    public class AllAppointmentsByBarberViewComponent : ViewComponent
    {
        private readonly IAppointmentsService _appointmentsService;

        public AllAppointmentsByBarberViewComponent(IAppointmentsService appointmentsService)
        {
            _appointmentsService = appointmentsService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int Id)
        {

            var model = await _appointmentsService.GetAllAppointmentsBySalon<AppointmentViewModel>(Id);

            return View(model);
        }
    }
}
