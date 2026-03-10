public class Utente
{
    public string Nome;

    public Utente(string nome)
    {
        Nome = nome;
    }

    public override string ToString()
    {
        return $"Utente {Nome}";
    }
}

public class UserFactory
{
    public static Utente Crea(string nome)
    {
        return new Utente(nome);
    }
}

public interface IObserver2
{
    public void NotificaCreazione(string nomeUtente);
}

public interface ISoggetto2
{
    public void Registra(IObserver2 o2);
    public void Rimuovi(IObserver2 o2);
    public void Notifica(string nomeUtente);
}

public sealed class GestoreCreazioneUtente : ISoggetto2
{
    private List<IObserver2> lstObs = new();

private static GestoreCreazioneUtente _istance = new();

public static GestoreCreazioneUtente Istanza
    {
        get => _istance;
    }

private GestoreCreazioneUtente()
    {
        
    }

    public void Registra(IObserver2 o2)
    {
        lstObs.Add(o2);
    }

    public void Rimuovi(IObserver2 o2)
    {
        lstObs.Remove(o2);
    }

    public void Notifica(string nomeUtente)
    {
        foreach (var o in lstObs)
        {
            o.NotificaCreazione(nomeUtente);
        }
    }

    public void CreaUtente(string nome)
    {
        Utente u = UserFactory.Crea(nome);
        Notifica(nome);
    }
}

public class ModuloLog : IObserver2
{
    public void NotificaCreazione(string nomeUtente)
    {
        Console.WriteLine($"\nNuovo utente creato - Modulo Log - {nomeUtente}");
    }
}

public class ModuloMarketing : IObserver2
{
    public void NotificaCreazione(string nomeUtente)
    {
        Console.WriteLine($"\nNuovo utente creato - Modulo Marketing - {nomeUtente}");
    }
}