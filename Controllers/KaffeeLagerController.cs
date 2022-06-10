using Microsoft.AspNetCore.Mvc;

namespace KaffeeMaschine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KaffeelagerController : ControllerBase
    {
        KaffeeLager Lager;
        private readonly ILogger<KaffeelagerController> _logger;

        public KaffeelagerController(ILogger<KaffeelagerController> logger, KaffeeLager argLager)
        {
            _logger = logger;
            Lager = argLager;
        }

        [HttpGet, Route("LagerInhalt")]
        public double Lagerinhalt()
        {
            return Lager.fuellstand;
        }

        [HttpPut, Route("ChangeLager")]
        public double ChangeLagerinhalt(double menge)
        {
            return Lager.fuellstand += menge;
        }
    }
}
