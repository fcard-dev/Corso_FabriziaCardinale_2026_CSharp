public class Veicolo
{
    public string Marca;
    public string Modello;

    public virtual void StampaInfo()
    {
        Console.WriteLine($"Marca {Marca}, Modello {Modello}");
    }
}
public class Auto : Veicolo
{
    public int NumeroPorte;
    public override void StampaInfo()
    {
        Console.WriteLine($"Auto - Marca: {Marca}, Modello: {Modello}, Numero porte: {NumeroPorte}");
    }
}

public class Moto : Veicolo
{
    public string TipoManubrio;
    public override void StampaInfo()
    {
        Console.WriteLine($"Moto - Marca: {Marca}, Modello: {Modello}, Tipo manubrio: {TipoManubrio}");
    }
}
