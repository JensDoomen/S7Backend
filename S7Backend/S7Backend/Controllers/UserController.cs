using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft;
using S7Backend.Database.Context;
using S7Backend.Models;
using System.Text;

namespace S7Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext dc;
        private readonly ILogger<WeatherForecastController> _logger;

        public UserController(ILogger<WeatherForecastController> logger, DataContext dc)
        {
            _logger = logger;
            this.dc = dc;
        }
       

        [HttpPost]
        public IActionResult Post()
        {
            try
            {
                User user = new User();
                user.Id = Guid.NewGuid().ToString();
                user.Name = "test";
                dc.Add(user);
                _logger.LogInformation($"Data stored in DB");
                return Ok( user );
            }
            catch (Exception ex)
            {
                _logger.LogError("application encountered an error with the database");
                Response.Redirect("Error.aspx");
                return ((IActionResult)ex);
               

            }
        }
    }
}
