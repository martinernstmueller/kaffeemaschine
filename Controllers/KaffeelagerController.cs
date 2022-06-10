using KaffeeMaschineVar;
using Microsoft.AspNetCore.Mvc;

namespace KaffeeMaschine.Controllers
{
    public class KaffeelagerController : Controller
    {
        private KaffeelagerClass Kaffeelager;

        public KaffeelagerController(KaffeelagerClass Kaffeelager)
        {
            this.Kaffeelager = Kaffeelager;
        }
        
        [HttpGet, Route("GetLagerMenge")]
        public double getLagerMenge()
        {
            return Kaffeelager.Bohnenlager;
        }


        [HttpPut, Route("ChangeMenge")]
        public string ChangeLagerMenge(double menge)
        {
            return Kaffeelager.changeBonen(menge);
        }
    }
}
