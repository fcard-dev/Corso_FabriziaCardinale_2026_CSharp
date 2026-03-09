public sealed class Logger3
{
    private static Logger3 _istance3 = new();
    private List<string> _log;
    private Logger3()
    {
        _log = new();
    }
    public static Logger3 Istance3
    {
        get => _istance3;
    }

public void Log(string message)
    {
        _log.Add(message);
    }
public void StampaTutto()
    {
        Console.WriteLine($"\nStampa totale:");
        
        foreach (var l in _log)
        {
            Console.WriteLine(l);
        }
    }
}