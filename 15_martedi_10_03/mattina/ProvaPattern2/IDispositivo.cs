public interface IDispositivo
{
    public void Avvia();
    public void MostraTipo();
}

public class Computer : IDispositivo
{
    public void Avvia()
    {
        Console.WriteLine($"Il computer si avvia.");
    }
    public void MostraTipo()
    {
        Console.WriteLine($"Tipo: Computer.");
    }
}

public class Stampante : IDispositivo
{
    public void Avvia()
    {
        Console.WriteLine($"La stampante si avvia.");
    }
    public void MostraTipo()
    {
        Console.WriteLine($"Tipo: Stampante.");
    }
}