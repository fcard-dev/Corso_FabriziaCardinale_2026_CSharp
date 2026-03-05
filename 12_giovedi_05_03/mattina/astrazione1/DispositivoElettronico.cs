public abstract class DispositivoElettronico
{
    private string modello;

    public string Modello
    {
        get => modello;
        set => modello = value;
    }

    public abstract string Accendi();
    public abstract string Spegni();
    public virtual string MostraInfo()
    {
        return $"\nModello: {modello}";
    }
}