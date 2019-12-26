using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
     [EnableCors("_myAllowSpecificOrigins")]
    public class WeatherForecastController : ControllerBase
    {        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly DataContext _context;
        public WeatherForecastController(DataContext context,ILogger<WeatherForecastController> logger)
        {
            this._context = context;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
           var values1=_context.values.ToList();
           return Ok(values1);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
           var values1=_context.values.FirstOrDefault(x=>x.Id==id);
                      return Ok(values1);
        }
    }
}
