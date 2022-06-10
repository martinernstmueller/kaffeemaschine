namespace KaffeeMaschine;

public class Kaffeelager
{
    public double lagerstand{get; set;}
    
    public Kaffeelager()
    {
    }
    
    public double setlager(double amount)
    {
        lagerstand += amount;
        return lagerstand;
    }
    
    public double getlager()
    {
        return lagerstand;
    }
}