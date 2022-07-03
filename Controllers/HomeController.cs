using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sample_app.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sample_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Get()
        {
            Machine hostMachine = new Machine();
            hostMachine.Name = Environment.MachineName;
            hostMachine.OsVersion = Environment.OSVersion.ToString();
            hostMachine.Processors = Environment.ProcessorCount.ToString();

            return Ok(hostMachine);
        }
    }
}
