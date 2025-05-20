using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

/*
NOTA
Si tiene experiencia con el desarrollo con Razor Pages o el desarrollo de la
arquitectura Modelo-Vista-Controlador (MVC) en ASP.NET Core, ha usado la clase
Controller. No cree un controlador de API web mediante la derivación de la clase
Controller. Controller se deriva de ControllerBase y agrega compatibilidad con
vistas, por lo que sirve para gestionar páginas web, no solicitudes de API web.
*/

[ApiController]
[Route("[controller]")]
//public class WeatherForecastController(ILogger<WeatherForecastController> logger) : ControllerBase
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries =
    [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return [.. Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })];
    }
}
