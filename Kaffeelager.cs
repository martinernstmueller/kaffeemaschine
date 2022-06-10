namespace KaffeeMaschineVar
{
    public class KaffeelagerClass
    {
        public double Bohnenlager { get; set; }

        public KaffeelagerClass(double Bohnenlager = 0)
        {
            this.Bohnenlager = Bohnenlager;
        }

        public string changeBonen(double menge)
        {
            if (menge > 0)
                Bohnenlager += menge;

            if (menge < 0)
                if (Bohnenlager - menge > 0)
                    Bohnenlager -= menge;
                else
                    return "Es befinden sich zu wenig Bohnen im Lager";

                
           
            return "Jetzt befinden sich " + Bohnenlager + " im Lager";
         }   
    }

}
