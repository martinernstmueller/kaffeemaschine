using Microsoft.AspNetCore.Mvc;

namespace KaffeeMaschine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KaffeeController : ControllerBase
    {
        static Kaffee kaffee = new Kaffee(1,1);
        KaffeeLager lager;

        private readonly ILogger<KaffeeController> _logger;

        public KaffeeController(ILogger<KaffeeController> logger, KaffeeLager argLager)
        {
            _logger = logger;
            
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

        [HttpGet()]
        [Route("BohnenKaffeeLager")]
        public double GetBohnenFüllstandKaffeeLager()
        {
            return lager.bohnen;
        }

        [HttpPut()]
        [Route("PutBohnen")]

        public double PutBohnen(double menge)
        {
            return kaffee.bohnenAuffuellen(menge);

        }

        [HttpPut()]
        [Route("PutBohnenKaffeeLager")]

        public double PutBohnenKaffeeLager(double menge)
        {
            return lager.bohnenAuffuellenKaffeeLager(menge);

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