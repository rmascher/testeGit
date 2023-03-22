using Microsoft.AspNetCore.Mvc;

namespace GitTests.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeatureAController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
         "Bracing",  "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "FeatureE", "FeatureD"
    };

        private readonly ILogger<FeatureAController> _logger;

        public FeatureAController(ILogger<FeatureAController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetFeatureA")]
        public IEnumerable<WeatherForecast> Get()
        {
            var summary = Summaries[Random.Shared.Next(Summaries.Length)];
            var date = DateTime.Now.AddDays(index);
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = date,
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summary
            })
            .ToArray();
        }
    }
}