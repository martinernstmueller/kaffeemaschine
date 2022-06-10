namespace KaffeeMaschine
{
    public class Kaffeelager
    {
        public double lagerstand { get; set; }

        public Kaffeelager(double lagerstand)
        {
            this.lagerstand = lagerstand;
        }

        public double getLagerstand()
        {
            return lagerstand;
        }

        public double setLagerstand(double newLagerstand)
        {
            lagerstand = newLagerstand;
            return lagerstand;
        }
    }
}
