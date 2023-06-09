﻿using Microsoft.AspNetCore.Mvc;

namespace CRM01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastyController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastyController> _logger;

        public WeatherForecastyController(ILogger<WeatherForecastyController> logger)
        {
            _logger = logger;
            _logger.LogInformation("Test");
            _logger.LogInformation(TestController.testString());

          
        }

        [HttpGet]
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
    }
}