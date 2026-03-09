public interface IVeicolo
{
    public void Avvia();    

    public void MostraTipo();
    
}

public class Moto : IVeicolo
{
    public void Avvia()
    {
        Console.WriteLine($"Avvio della moto");
    }

    public void MostraTipo()
    {
        Console.WriteLine($"Tipo: Moto");
    }
}

public class Auto : IVeicolo
{
    public void Avvia()
    {
        Console.WriteLine($"Avvio dell'auto");
    }

    public void MostraTipo()
    {
        Console.WriteLine($"Tipo: Auto");
    }
}

public class Camion : IVeicolo
{
    public void Avvia()
    {
        Console.WriteLine($"Avvio del camion");
    }

    public void MostraTipo()
    {
        Console.WriteLine($"Tipo: Camion");
    }
}