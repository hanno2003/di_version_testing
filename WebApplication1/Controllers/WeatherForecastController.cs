using Autofac.Features.Indexed;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {        

        public readonly IIndex<string, ITesting> _testing;

        public WeatherForecastController(IIndex<string, ITesting> test)
        {
            _testing = test;
        }

        [HttpPost]
        public string Test([FromHeader]string version, string test)
        {
            return _testing[version].ReverseName(test);
        }
    }
}
