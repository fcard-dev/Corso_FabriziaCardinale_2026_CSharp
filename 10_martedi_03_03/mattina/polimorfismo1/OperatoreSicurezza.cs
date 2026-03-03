public class OperatoreSicurezza : Operatore
{
    public string areaSorvegliata;

    public override string EseguiCompito()
    {
        return $"Sorveglianza dell'area {areaSorvegliata}";
    }
}