public class Operatore
{
    private string nome;
    private string turno;

    public string Nome
    {
        get => nome;
        set => nome = value;
    }

    public string Turno
    {
        get => turno;
        set
        {
            if (value == "giorno" || value == "notte")
            {
                turno = value;
            }
        }
    }

    public virtual string EseguiCompito()
    {
        return $"Operatore generico in servizio";
    }
}