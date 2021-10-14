using APITeste.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IOptions<EndPointConecao> _option;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IOptions<EndPointConecao> option)
        {
            _logger = logger;
            _option = option;
        }

        [HttpGet("opcao:int")]
        public string Get(int opcao)
        {
            return _option.RetornaURL(opcao);
        }
    }
}
