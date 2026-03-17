public interface ILogger
{
    void Log(string messaggio);
}

public class ConsoleLogger : ILogger
{
    public void Log(string messaggio)
    {
        Console.WriteLine($"Messaggio di log: {messaggio}");
    }
}

public class Printer
{
    public ILogger logger { get; set; }

    public void Print(string messaggio)
    {
        if (logger != null)
        {
            logger.Log(messaggio);
        }
        else
        {
            Console.WriteLine($"Errore");
        }
    }
}