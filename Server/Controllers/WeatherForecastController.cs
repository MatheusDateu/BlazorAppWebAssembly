using BlazorAppWebAssembly.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAppWebAssembly.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Despachou processos", "Assinou processos", "Envio alertas via Whatsapp", "Enviou alertas via Email", 
        "Converteu arquivos em PDF", "Preencheu planilha", "Verificou se havia novos processos", "Alterou acessos", 
        "Abriu chamados", "Verificou alertas"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
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