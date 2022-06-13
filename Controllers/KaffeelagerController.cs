using Microsoft.AspNetCore.Mvc;

namespace KaffeeMaschine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KaffeelagerController : ControllerBase
    {

        private readonly ILogger<KaffeelagerController> _logger;
        Kaffeelager lager;
        public KaffeelagerController(ILogger<KaffeelagerController> logger, Kaffeelager _lager)
        {
            _logger = logger;
            lager = _lager;
            
        }

        [HttpGet()]
        [Route("Lagerstand")]
        public double getLagerstand()
        {
            return lager.lagerstand;
        }

        [HttpPut()]
        [Route("Lagerauffuellen")]

        public double lagerauffuellen(double menge)
        {
            lager.lagerstand += menge;
            return lager.lagerstand;
        }
    }
}