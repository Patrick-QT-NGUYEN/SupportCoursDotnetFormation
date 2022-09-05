using CoursJWTApiRestFull.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoursJWTApiRestFull.Controllers
{
    [ApiController]
    [Route("[controller]")]
    // Indique une politique de restriction d'accès sur le controlleur
    [Authorize]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private TokenService _tokenService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, TokenService tokenService)
        {
            _logger = logger;
            _tokenService = tokenService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("token")]
        // Autorise tous les utilisateurs
        [AllowAnonymous]
        public string GetToken()
        {
            return _tokenService.Authenticate("toto", "tata");
        }
    }
}