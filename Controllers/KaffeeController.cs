using Microsoft.AspNetCore.Mvc;

namespace KaffeeMaschine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KaffeeController : ControllerBase
    {
        Kaffee kaffee;

        private readonly ILogger<KaffeeController> _logger;

        public KaffeeController(ILogger<KaffeeController> logger, Kaffee argKaffee)
        {
            _logger = logger;
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