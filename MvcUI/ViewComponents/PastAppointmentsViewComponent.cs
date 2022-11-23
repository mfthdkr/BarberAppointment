using System.Threading.Tasks;
using BusinessLayer.Models.Appointments;
using BusinessLayer.Services.Appointments;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.ViewComponents
{
    
    public class PastAppointmentsViewComponent : ViewComponent
    {
        private readonly IAppointmentsService _appointmentsService;
        private readonly UserManager<ApplicationUser> _userManager;

        public PastAppointmentsViewComponent(
            IAppointmentsService appointmentsService,
            UserManager<ApplicationUser> userManager)
        {
            _appointmentsService = appointmentsService;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var userId = await _userManager.GetUserIdAsync(user);
            
            var result = await _appointmentsService.GetPastByUser<AppointmentViewModel>(userId);

            return View(result);
        }
    }
}
