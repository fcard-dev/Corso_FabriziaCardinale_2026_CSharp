public class Gallina : Animale
{
    private bool _uovaFatte;

    public bool UovaFatte
    {
        get => _uovaFatte;
        set => _uovaFatte = value;
    }

    //costruttore
    public Gallina(string _nome, int _eta, bool _uovaFatte) : base(_nome, _eta)
    {
        UovaFatte = _uovaFatte;
    }

    public override string MostraInfo()
    {
        string uovaCovate = UovaFatte ? "Ha fatto le uova" : "Non ha fatto le uova.";
        return $"{base.MostraInfo()}, {uovaCovate}";
    }

    public override void Verso()
    {
        Console.WriteLine($"La gallina fa coccodè.");
    }
}