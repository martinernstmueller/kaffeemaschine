namespace KaffeeMaschine
{
    public class KaffeeLager
    {
        public double bohnen { get; private set; }
        private double maxBohnen = 100;


        public KaffeeLager(double argBohnen, double argWasser)
        {
            argBohnen = (argBohnen > maxBohnen) ? 100 :  argBohnen;
            bohnen = argBohnen;
        }

        public double bohnenAuffuellenKaffeeLager(double menge)
        {
            bohnen = ((bohnen + menge) > maxBohnen) ? maxBohnen : bohnen + menge;
            return bohnen;
        }
    }
}