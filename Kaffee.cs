namespace KaffeeMaschine
{
    public class Kaffee
    {
        public double wasser { get; private set; }
        public double bohnen { get; private set; }
        private double maxWasser = 2.5;
        private double maxBohnen = 2.5;


        public Kaffee(double argBohnen, double argWasser)
        {
            argBohnen = (argBohnen > maxBohnen) ? 2.5 : argBohnen;
            argWasser = (argWasser > maxWasser) ? maxWasser : argWasser;
            bohnen = argBohnen;
            wasser = argWasser;
        }

        public double wasserAuffuellen(double menge)
        {
            wasser = ((wasser + menge) > maxWasser) ? maxWasser : wasser + menge;
            return wasser;
        }

        public double bohnenAuffuellen(double menge)
        {
            double bohnenanfang = bohnen;
            bohnen = ((bohnen + menge) > maxBohnen) ? maxBohnen : bohnen + menge;
            double bohnenende = bohnen;
            return bohnen;
        }


        public double machKaffee(double menge, double verhaeltnisWasserBohnen)
        {
            var mengeWasser = menge / 2 * verhaeltnisWasserBohnen;
            var mengeBohnen = menge / 2 * (1 / verhaeltnisWasserBohnen);
            if (wasser < mengeWasser)
                return -1.0;
            if (bohnen < mengeBohnen)
                return -2.0;

            wasser -= mengeWasser;
            bohnen -= mengeBohnen;

            return menge;
        }



    }
}