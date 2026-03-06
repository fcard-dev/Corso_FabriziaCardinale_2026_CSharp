public class Mucca : Animale
{
    private bool _latteFatto;

    public bool LatteFatto
    {
        get => _latteFatto;
        set => _latteFatto = value;
    }

    //costruttore
    public Mucca(string _nome, int _eta, bool _latteFatto) : base(_nome, _eta)
    {
        LatteFatto = _latteFatto;
    }

    public override string MostraInfo()
    {
        string statoLatte = LatteFatto ? "Ha fatto il latte" : "Non ha fatto il latte.";
        return $"{base.MostraInfo()}, {statoLatte}";
    }

    public override void Verso()
    {
        Console.WriteLine($"La mucca muggisce.");
    }
}