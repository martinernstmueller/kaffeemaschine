namespace KaffeeMaschine
{
    public class KaffeeLager
    {
        public double kaffee { get; private set; }


        public KaffeeLager(double lager)
        {
            kaffee = lager;
        }

        public double getLagerKaffee()
        {
            return kaffee;
        }

        public double LagerKaffeeAuffüllen(double menge)
        {
            kaffee += menge;
            return kaffee;
        }
    }
}






