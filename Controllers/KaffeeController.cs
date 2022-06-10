using Microsoft.AspNetCore.Mvc;

namespace KaffeeMaschine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KaffeeController : ControllerBase
    {
        static Kaffee kaffee = new Kaffee(0,1);
        private KaffeeLager kaffeeLager;

        private readonly ILogger<KaffeeController> _logger;

        public KaffeeController(KaffeeLager _kaffeeLager ,ILogger<KaffeeController> logger)
        {
            _logger = logger;
            kaffeeLager = _kaffeeLager;
        }

        [HttpGet()]
        [Route("Wasser")]
        public double GetWasserstand()
        {
            return kaffee.wasser;
        }


        [HttpGet()]
        [Route("Bohnen")]
        public double GetBohnenFüllstand()
        {
            return kaffee.bohnen;
        }

        [HttpPut()]
        [Route("PutBohnen")]

        public double PutBohnen(double menge)
        {
            kaffee.bohnenAuffuellen(menge);
            kaffeeLager.lagerstand -= menge;
            return kaffee.bohnen;

        }

        [HttpPut()]

        [Route("PutWasser")]
        public double PutWasser(double menge)
        {
            return kaffee.wasserAuffuellen(menge);

        }

        [HttpPut()]

        [Route("MachKaffee")]
        public IActionResult MachKaffee(double menge, double verhaeltnisWasserBohnen)
        {
            var retval = kaffee.machKaffee(menge, verhaeltnisWasserBohnen);
            if (retval == menge)
            {
                return Ok("Restwasser: " + kaffee.wasser + ". Restbohnen: " + kaffee.bohnen + ".");
            }

            return Conflict("Not enough water or beens... please fill up first!");

        }


    }
}