public class Soldato
{
    private string nome;
    private string grado;
    private int anniServizio;

    public string Nome
    {
        get => nome;
        set => nome = value;
    }

    public string Grado
    {
        get => grado;
        set => grado = value;
    }

    public int AnniServizio
    {
        get => anniServizio;
        set
        {
            if(value >= 0)
            {
                anniServizio = value;
            }
        }
    }

    public virtual string Descrizione()
    {
        return $"Nome: {nome} | Grado: {grado} | Anni di servizio: {anniServizio}";
    }
}