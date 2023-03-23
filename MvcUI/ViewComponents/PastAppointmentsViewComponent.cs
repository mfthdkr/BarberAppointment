using BusinessLayer.Models;
using BusinessLayer.Services.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.ViewComponents
{

    public class PastAppointmentsViewComponent : ViewComponent
    {
        private readonly IAppointmentsService _appointmentsService;
        private readonly UserManager<User> _userManager;

        public PastAppointmentsViewComponent(
            IAppointmentsService appointmentsService,
            UserManager<User> userManager)
        {
            _appointmentsService = appointmentsService;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var userId = await _userManager.GetUserIdAsync(user);
            
            var result = await _appointmentsService.GetPastAppointmentsByUser<AppointmentViewModel>(userId);

            return View(result);
        }
    }
}
