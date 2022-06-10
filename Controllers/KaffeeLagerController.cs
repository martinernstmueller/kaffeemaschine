using Microsoft.AspNetCore.Mvc;

namespace KaffeeMaschine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KaffeeLagerController : ControllerBase
    {
        private readonly Kaffeelager kaffeelager;
        private readonly ILogger<KaffeeLagerController> _logger;

        public KaffeeLagerController(ILogger<KaffeeLagerController> logger, Kaffeelager kaffeelager)
        {
            _logger = logger;
            this.kaffeelager = kaffeelager;

        }


        [HttpGet()]
        [Route("Bohnen")]
        public double GetBohnenGelagert()
        {
            return kaffeelager.bohnen;
        }

        [HttpPut()]
        [Route("PutBohnen")]

        public double PutBohnen(double menge)
        {
            return kaffeelager.bohnenEntnehmen(menge);

        }

    }
}