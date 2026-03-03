public class OperatoreLogistica : Operatore
{
    private int numeroConsegne;

    public int NumeroConsegne
    {
        get => numeroConsegne;
        set
        {
            if (value >= 0)
            {
                numeroConsegne = value;
            }
        }
    }

    public override string EseguiCompito()
    {
        return $"Coordinamento di {numeroConsegne} consegne";
    }
}