using System.Runtime.ConstrainedExecution;

public class Veicolo
{
    private string targa;

    public string Targa
    {
        get => targa;
        set => targa = value;
    }

    public virtual string Ripara()
    {
        return $"Il veicolo viene controllato";
    }
}