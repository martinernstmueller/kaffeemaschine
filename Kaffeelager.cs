using Microsoft.AspNetCore.Mvc;

namespace KaffeeMaschine
{
    public class Kaffeelager
    {
        public double Lagerstand { get; private set; }



        public Kaffeelager(double argLagerstand)
        {

            Lagerstand = argLagerstand;
        }

        public double LagerAuffuellen(double Lagerauffuellen)
        {
            Lagerstand += Lagerauffuellen;
            return Lagerstand;
        }



        public String bohnenauffuellen(double bohenaufgefuellt)
        {

            if (Lagerstand < bohenaufgefuellt)
            {
                return "Es sind nicht genügend Bohnen im Lager!";

            }
            Lagerstand = Lagerstand - bohenaufgefuellt;
            return "Bohnen aufgefüllt, Lagerstand: " + Lagerstand;
        }

    }
}
