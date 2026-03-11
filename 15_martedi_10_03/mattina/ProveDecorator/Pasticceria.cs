//interfaccia torta 
public interface ITorta
{
    public string Descrizione();
}

public class TortaCioccolato : ITorta
{
    public string Descrizione()
    {
        return "Torta al cioccolato";
    }
}

public class TortaVaniglia : ITorta
{
    public string Descrizione()
    {
        return "Torta alla vaniglia";
    }
}

public class TortaFrutta : ITorta
{
    public string Descrizione()
    {
        return "Torta alla frutta";
    }
}

//Factory method
public class TortaFactory
{
    public static ITorta CreaTortaBase(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "cioccolato": return new TortaCioccolato();
            case "vaniglia": return new TortaVaniglia();
            case "frutta": return new TortaFrutta();
            default:
                Console.WriteLine($"Tipo errato");
                return null;
        }
    }
}

//Decorator
public abstract class DecoratoreTorta : ITorta
{
    protected ITorta baseTorta;

    protected GestoreTorta gestoreTorta;

    public DecoratoreTorta(ITorta torta, GestoreTorta gestore)
    {
        baseTorta = torta;
        gestoreTorta = gestore;
    }

    public virtual string Descrizione()
    {
        return baseTorta.Descrizione();
    }
}

//Concrete Decorator
public class ConPanna1 : DecoratoreTorta
{
    public ConPanna1(ITorta torta, GestoreTorta gestore)
        : base(torta, gestore)
    {
        gestore.Notifica("Aggiunta panna.");
    }

    public override string Descrizione()
    {
        return $"{base.Descrizione()} + panna";
    }
}

public class ConFragole : DecoratoreTorta
{
    public ConFragole(ITorta torta, GestoreTorta gestore)
        : base(torta, gestore)
    {
        gestore.Notifica("Aggiunta fragole.");
    }

    public override string Descrizione()
    {
        return $"{base.Descrizione()} + fragole";
    }
}

public class ConGlassa : DecoratoreTorta
{
    public ConGlassa(ITorta torta, GestoreTorta gestore)
        : base(torta, gestore)
    {
        gestore.Notifica("Aggiunta glassa.");
    }

    public override string Descrizione()
    {
        return $"{base.Descrizione()} + glassa";
    }
}

//observer

//interfaccia observer
public interface IObserverTorta
{
    public void NotificaDecorazione(string descrizione);
}

//interfaccia subject
public interface ISoggettoTorta
{
    public void Registra(IObserverTorta oT);
    public void Rimuovi(IObserverTorta oT);
    public void Notifica(string descrizione);
}

//classe gestore observer + singleton
public class GestoreTorta : ISoggettoTorta
{
    private List<IObserverTorta> lstObsTorta = new();

    //singleton

    //istanza privata
    private static GestoreTorta _istance = new();

    //proprietà pubblica
    public static GestoreTorta Istanza
    {
        get => _istance;
    }

    //costruttore privato
    private GestoreTorta()
    {

    }

    public void Registra(IObserverTorta oT)
    {
        lstObsTorta.Add(oT);
    }

    public void Rimuovi(IObserverTorta oT)
    {
        lstObsTorta.Remove(oT);
    }

    public void Notifica(string descrizione)
    {
        foreach (var o in lstObsTorta)
        {
            o.NotificaDecorazione(descrizione);
        }
    }

//notifica agli observer
    public ITorta CreaTorta(string tipo)
    {
        ITorta torta = TortaFactory.CreaTortaBase(tipo);
        Notifica($"Base torta {torta.Descrizione()}");
        return torta;
    }
}

//concrete observer
public class ModuloLog : IObserverTorta
{
    public void NotificaDecorazione(string descrizione)
    {
        Console.WriteLine($"\nModulo Log - {descrizione}");
    }
}
