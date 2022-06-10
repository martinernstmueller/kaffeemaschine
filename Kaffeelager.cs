namespace KaffeeMaschine
{
    public class Kaffeelager
    {
        public double bohnen { get; set; }

        private double maxBohnen = 50;


        public Kaffeelager()
        {
            bohnen = 10;
        }


        public double bohnenAuffuellen(double menge)
        {
            bohnen = ((bohnen + menge) > maxBohnen) ? maxBohnen : bohnen + menge;
            return bohnen;
        }


        public double bohnenEntnehmen(double menge)
        {
            bohnen = (bohnen - menge < 0 ? 0 : bohnen - menge);
            return bohnen;
        }

    }
}