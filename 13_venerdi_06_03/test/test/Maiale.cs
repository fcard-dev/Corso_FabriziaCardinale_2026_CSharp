public class Maiale : Animale
{
    private double _peso;

    public double Peso
    {
        get => _peso;
        set
        {
            if (value > 0)
            {
                _peso = value;
            }
            else
            {
                Console.WriteLine($"Peso non valido");
            }
        }
    }

    //costruttore
    public Maiale(string _nome, int _eta, double _peso) : base(_nome, _eta)
    {
        Peso = _peso;
    }

    public override string MostraInfo()
    {
        return $"{base.MostraInfo()} e pesa {Peso} kg.";
    }

    public override void Verso()
    {
        Console.WriteLine($"Oink oink.");
    }
}