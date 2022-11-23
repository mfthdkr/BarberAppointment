using System.Threading.Tasks;
using BusinessLayer.Models.Appointments;
using BusinessLayer.Services.Appointments;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IAppointmentsService _appointmentsService;

        public TestController(IAppointmentsService appointmentsService)
        {
            _appointmentsService = appointmentsService;
        }

        // GET: api/<TestController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result =
                await _appointmentsService.GetUpcomingByUserTest<AppointmentViewModel>(
                    "8c9d4a7a-b2bd-41a6-bddc-2326728b0079");

            return Ok(result);
        }

        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
