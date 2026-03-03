public class OperatoreEmergenza : Operatore
{
    private int livelloUrgenza;

    public int LivelloUrgenza
    {
        get => livelloUrgenza;
        set
        {
            if (value >= 1 && value <= 5)
            {
                livelloUrgenza = value;
            }
        }
    }

    public override string EseguiCompito()
    {
        return $"Gestione emergenza di livello {livelloUrgenza}";
    }
}