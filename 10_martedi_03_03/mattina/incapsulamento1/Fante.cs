public class Fante : Soldato
{
    private string arma;

    public string Arma
    {
        get => arma;
        set => arma=value;
    }

    public override string Descrizione()
    {
        return base.Descrizione() + $" | Arma: {arma}";
    }
}