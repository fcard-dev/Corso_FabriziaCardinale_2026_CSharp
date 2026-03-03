public class Artigliere : Soldato
{
    private int calibro;

    public int Calibro
    {
        get => calibro;
        set
        {
            if (value >= 0)
            {
                calibro = value;
            }
        }
    }

    public override string Descrizione()
    {
        return base.Descrizione() + $" | Calibro: {calibro}";
    }
}