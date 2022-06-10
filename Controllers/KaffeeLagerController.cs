using Microsoft.AspNetCore.Mvc;

namespace KaffeeMaschine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KaffeeLagerController : ControllerBase
    {
        KaffeeLager kaffeelager;
        private readonly ILogger<KaffeeController> _logger;

        public KaffeeLagerController(ILogger<KaffeeController> logger, KaffeeLager argLager)
        {
            _logger = logger;
            kaffeelager = argLager;
        }

        [HttpGet()]
        [Route("Bohnen")]
        public double GetBohnenFüllstand()
        {
            return kaffeelager.fuellstand;
        }

        [HttpPut()]
        [Route("PutBohnen")]

        public double PutBohnen(double menge)
        {
            return kaffeelager.fuellstand += menge;
        }
    }
}