using Microsoft.AspNetCore.Mvc;

namespace KaffeeMaschine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KaffeeLagerController : ControllerBase
    {
        KaffeeLager kaffeelager;
        private readonly ILogger<KaffeeLager> _logger;

        public KaffeeLagerController(ILogger<KaffeeLager> logger, KaffeeLager argLager)
        {
            _logger = logger;
            kaffeelager = argLager;
                   }

        [HttpGet()]
        [Route("Fuellstand")]
        public double GetFuellstand()
        {
            return kaffeelager.fuellstand;
        }

        [HttpPut()]
        [Route("PutBohnen")]
        public double PutBohnen(double menge)
        {
            kaffeelager.fuellstand += menge;
            return kaffeelager.fuellstand;
        }

    }
}