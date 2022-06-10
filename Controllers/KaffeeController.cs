using Microsoft.AspNetCore.Mvc;

namespace KaffeeMaschine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KaffeeController : ControllerBase
    {
        static Kaffee kaffee = new Kaffee(1, 1);
        static Kaffeelager Kaffeelager = new Kaffeelager(0);

        private readonly ILogger<KaffeeController> _logger;



        public KaffeeController(ILogger<KaffeeController> logger)
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



        [HttpPut()]
        [Route("PutBohnen")]

        public String PutBohnen(double menge)
        {
            double bohenaufgefuellt = kaffee.bohnenAuffuellen(menge);

            return Kaffeelager.bohnenauffuellen(bohenaufgefuellt) + " Bohnen in der Maschine: " + kaffee.bohnen;


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

            return Conflict("Not enough water or beans... please fill up first!");

        }

        [HttpGet()]
        [Route("Kaffeelager")]
        public double getLagerstand()
        {
            return Kaffeelager.Lagerstand;
        }



        [HttpPut()]
        [Route("LagerAuffuellen")]
        public double Lagerauffuellen(double menge)
        {
            return Kaffeelager.LagerAuffuellen(menge);

        }




    }
}