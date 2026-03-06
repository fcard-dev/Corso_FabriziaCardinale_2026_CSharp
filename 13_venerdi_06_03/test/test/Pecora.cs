public class Pecora : Animale
{
    private string _coloreLana;

    public string ColoreLana
    {
        get => _coloreLana;
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && !string.IsNullOrEmpty(value))
            {
                _coloreLana = value;
            }
            else
            {
                Console.WriteLine($"Colore non valido");
            }
        }
    }

    //costruttore
    public Pecora(string _nome, int _eta, string _coloreLana) : base(_nome, _eta)
    {
        ColoreLana = _coloreLana;
    }

    public override string MostraInfo()
    {
        return $"{base.MostraInfo()} e il colore della lana è {ColoreLana}";
    }

    public override void Verso()
    {
        Console.WriteLine($"La pecora fa BEEEEE.");
    }
}