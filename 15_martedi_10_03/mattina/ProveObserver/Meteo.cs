public interface IObserver
{
    public void Aggiorna(string messaggio);
}

public interface ISoggetto
{
    public void Registra(IObserver osservatore);
    public void Rimuovi(IObserver osservatore);
    public void Notifica(string messaggio);
}

public class CentroMeteo : ISoggetto
{
    List<IObserver> lstObs = new();

    public void Registra(IObserver osservatore)
    {
        lstObs.Add(osservatore);
    }

    public void Rimuovi(IObserver osservatore)
    {
        lstObs.Remove(osservatore);
    }

    public void Notifica(string messaggio)
    {
        foreach (var o in lstObs)
        {
            o.Aggiorna(messaggio);
        }
    }
    public void AggiornaMeteo(string dati)
    {
        Console.WriteLine($"\nAggiornamento meteo: {dati}");
        Notifica(dati);
    }
}

public class DisplayConsole : IObserver
{
    public void Aggiorna(string messaggio)
    {
        Console.WriteLine($"\nAggiornamento ricevuto su Display Console: {messaggio}");
    }
}

public class DisplayMobile : IObserver
{
    public void Aggiorna(string messaggio)
    {
        Console.WriteLine($"\nAggiornamento ricevuto su Display Mobile: {messaggio}");
    }
}
