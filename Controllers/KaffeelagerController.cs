using Microsoft.AspNetCore.Mvc;

namespace KaffeeMaschine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KaffeelagerController : ControllerBase
    {
     

        private readonly Kaffeelager kaffeelager;
        private readonly ILogger<KaffeelagerController> _logger;

        public KaffeelagerController(ILogger<KaffeelagerController> logger, Kaffeelager kaffeelager)
        {
            _logger = logger;
            this.kaffeelager = kaffeelager;

        }

        [HttpGet()]
        [Route("Wasser")]
        public double GetWasserstand()
        {
            return kaffeelager.wasser;
        }


        [HttpGet()]
        [Route("Bohnen")]
        public double GetBohnenFüllstand()
        {
            return kaffeelager.bohnen;
        }

        [HttpPut()]
        [Route("PutBohnen")]

        public double PutBohnen(double menge)
        {
            return kaffeelager.bohnenAuffuellen(menge);

        }

        [HttpPut()]

        [Route("PutWasser")]
        public double PutWasser(double menge)
        {
            return kaffeelager.wasserAuffuellen(menge);

        }

    }
}
