using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace container_sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiGuidController : ControllerBase
    {

        private readonly ILogger<ApiGuidController> _logger;

        public WeatherForecastController(ILogger<ApiGuidController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ApiGuid> Get()
        {
            Guid guid = new Guid();
            return guid;
        }
    }
}
