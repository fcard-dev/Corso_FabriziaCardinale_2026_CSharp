public class Monitor
{
    public void Accendi()
    {
        Console.WriteLine($"Monitor acceso.");
    }

    public void Spegni()
    {
        Console.WriteLine($"Monitor spento.");
    }
}

public class Tastiera
{
    public void Accendi()
    {
        Console.WriteLine($"Tastiera accesa.");
    }

    public void Collega()
    {
        Console.WriteLine($"Tastiera collegata.");
    }

    public void Spegni()
    {
        Console.WriteLine($"Tastiera spenta.");
    }
}

public class Mouse
{
    public void Accendi()
    {
        Console.WriteLine($"Mouse acceso.");
    }

    public void Spegni()
    {
        Console.WriteLine($"Mouse spento.");
    }
}

public class SchedaVideo
{
    public void Avvia()
    {
        Console.WriteLine($"Scheda video avviata.");
    }

    public void Inizializza()
    {
        Console.WriteLine($"Scheda video inizializzata.");
    }

    public void Spegni()
    {
        Console.WriteLine($"Scheda video spenta.");
    }
}

//singleton + subject per observer
public class GamingSetupFacade : ISubject
{
    //observer
    private List<IObserver> lstObs = new();

    public void Registra(IObserver o)
    {
        lstObs.Add(o);
    }
    public void Rimuovi(IObserver o)
    {
        lstObs.Remove(o);
    }
    public void Notifica(string messaggio)
    {
        foreach (var ob in lstObs)
        {
            ob.Aggiorna(messaggio);
        }
    }

    //singleton
    private static GamingSetupFacade _istance = new GamingSetupFacade(new Monitor(), new Tastiera(), new Mouse(), new SchedaVideo());

    public static GamingSetupFacade istanza
    {
        get => _istance;
    }

    private Monitor _monitor;
    private Tastiera _tastiera;
    private Mouse _mouse;
    private SchedaVideo _schedaVideo;

    private GamingSetupFacade(Monitor monitor, Tastiera tastiera, Mouse mouse, SchedaVideo schedaVideo)
    {
        _monitor = monitor;
        _tastiera = tastiera;
        _mouse = mouse;
        _schedaVideo = schedaVideo;
    }

    public void AvviaPostazione()
    {
        Console.WriteLine($"\nAvvio postazione");

        _monitor.Accendi();
        _schedaVideo.Avvia();
        _schedaVideo.Inizializza();
        _mouse.Accendi();
        _tastiera.Accendi();
        _tastiera.Collega();

        Notifica("Postazione avviata con successo.");
    }

    public void SpegniPostazione()
    {
        Console.WriteLine($"\nSpengo postazione");

        _tastiera.Spegni();
        _mouse.Spegni();
        _schedaVideo.Spegni();
        _monitor.Spegni();

        Notifica("Postazione spenta con successo.");
    }
}

#region observer
public interface IObserver
{
    public void Aggiorna(string messaggio);
}

public interface ISubject
{
    public void Registra(IObserver o);
    public void Rimuovi(IObserver o);
    public void Notifica(string messaggio);
}

public class Log : IObserver
{
    public void Aggiorna(string messaggio)
    {
        Console.WriteLine($"Aggiornamento - Log - {messaggio}");
    }
}

#endregion