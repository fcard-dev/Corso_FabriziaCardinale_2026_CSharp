public interface INewsSubscriber
{
    public void Aggiorna(string messaggio);
}

public sealed class NewsAgency
{
    private string _news;
    public string News
    {
        get => _news;
        set
        {
            _news = value;
            Notifica(_news);
        }
    }

    private static NewsAgency _istance = new();

    public static NewsAgency Istanza
    {
        get => _istance;
    }

    private NewsAgency()
    {

    }

    List<INewsSubscriber> lstSubs = new();

    public void Registra(INewsSubscriber subs)
    {
        lstSubs.Add(subs);
    }

    public void Notifica(string messaggio)
    {
        foreach (var s in lstSubs)
        {
            s.Aggiorna(messaggio);
        }
    }
}

public class MobileApp : INewsSubscriber
{
    public void Aggiorna(string messaggio)
    {
        Console.WriteLine($"\nNotification on mobile: {messaggio}");
    }
}

public class EmailClient : INewsSubscriber
{
    public void Aggiorna(string messaggio)
    {
        Console.WriteLine($"\nEmail sent: {messaggio}");
    }
}
