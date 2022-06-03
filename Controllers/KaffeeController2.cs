using Microsoft.AspNetCore.Mvc;

namespace KaffeeMaschine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KaffeeController2 : ControllerBase
    {
        KaffeeMaschine kaffee;

        private readonly ILogger<KaffeeController> _logger;

        public KaffeeController2(ILogger<KaffeeController> logger, KaffeeMaschine argKaffee)
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
    }
}