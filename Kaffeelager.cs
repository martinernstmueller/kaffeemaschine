namespace KaffeeMaschine
{
    public class Kaffeelager
    {
        public double wasser { get; private set; }
        public double bohnen { get; private set; }
        private double maxWasser = 10;
        private double maxBohnen = 10;


        public Kaffeelager()
        {
            bohnen = 10;
            wasser = 10;
        }

        public double wasserAuffuellen(double menge)
        {
            wasser = ((wasser + menge) > maxWasser) ? maxWasser : wasser + menge;
            return wasser;
        }

        public double bohnenAuffuellen(double menge)
        {
            bohnen = ((bohnen + menge) > maxBohnen) ? maxBohnen : bohnen + menge;
            return bohnen;
        }


        public double wasserEntnehmen(double menge)
        {
            wasser = (wasser - menge < 0 ? 0 : wasser - menge);
            return wasser;
        }

        public double bohnenAuffuellen(double menge)
        {
            bohnen = (bohnen - menge < 0 ? 0 : bohnen - menge);
            return bohnen;
        }



       


    }
}

