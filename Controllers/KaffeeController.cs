using Microsoft.AspNetCore.Mvc;

namespace KaffeeMaschine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KaffeeController : ControllerBase
    {
        KaffeeMaschine kaffee;
        KaffeeLager kaffeelager;
        private readonly ILogger<KaffeeController> _logger;

        public KaffeeController(ILogger<KaffeeController> logger, KaffeeMaschine argKaffee, KaffeeLager argLager)
        {
            _logger = logger;
            kaffeelager = argLager;
            kaffee = argKaffee;
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
            kaffeelager.fuellstand -= menge;
            return kaffee.bohnenAuffuellen(menge);

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