using Microsoft.AspNetCore.Mvc;

namespace GitHubActionSample.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IActionResult> Get()
    {
        return Ok(Summaries);
    }

    [HttpGet("GetCount")]
    public  int GetCount()
    {
        return Summaries.Length;
    }
}
