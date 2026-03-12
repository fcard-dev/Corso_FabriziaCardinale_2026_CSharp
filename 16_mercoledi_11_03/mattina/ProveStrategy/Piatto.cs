#region Factory

//interfaccia di piatto con i metodi che devono essere implementati / component per decorator
public interface IPiatto
{
    public string Descrizione();
    public string Prepara();
}

//classi concrete di piatto e che implementano l'interfaccia
public class Pizza : IPiatto
{
    public string Descrizione()
    {
        return $"Pizza";
    }

    public string Prepara()
    {
        return Descrizione();
    }
}

public class Hamburger : IPiatto
{
    public string Descrizione()
    {
        return $"Hamburger";
    }

    public string Prepara()
    {
        return Descrizione();
    }
}

public class Insalata : IPiatto
{
    public string Descrizione()
    {
        return $"Insalata";
    }

    public string Prepara()
    {
        return Descrizione();
    }
}

//Factory Method 
public class PiattoFactory
{
    public static IPiatto Crea(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "pizza": return new Pizza();
            case "hamburger": return new Hamburger();
            case "insalata": return new Insalata();
            default:
                Console.WriteLine($"Scelta errata");
                return null;
        }
    }
}
#endregion

#region Decorator

//Decorator principale che implementa l'interfaccia iniziale
public abstract class IngredienteExtra : IPiatto
{
    protected IPiatto _piatto;

    public IngredienteExtra(IPiatto piatto)
    {
        _piatto = piatto;
    }

    public virtual string Descrizione()
    {
        return _piatto.Descrizione();
    }

    public virtual string Prepara()
    {
        return _piatto.Prepara();
    }
}

//Concrete decorator che implementa IngredienteExtra e aggiunge altri ingredienti
public class ConFormaggio : IngredienteExtra
{
    public ConFormaggio(IPiatto piatto) : base(piatto)
    {

    }

    public override string Descrizione()
    {
        return $"{base.Descrizione()} + formaggio";
    }
}

public class ConBacon : IngredienteExtra
{
    public ConBacon(IPiatto piatto) : base(piatto)
    {

    }

    public override string Descrizione()
    {
        return $"{base.Descrizione()} + bacon";
    }
}

public class ConSalsa : IngredienteExtra
{
    public ConSalsa(IPiatto piatto) : base(piatto)
    {

    }

    public override string Descrizione()
    {
        return $"{base.Descrizione()} + salsa";
    }
}
#endregion

#region Strategy + Singleton + Subject x Observer
//interfaccia per lo stategy
public interface IPreparazioneStrategica
{
    public string Prepara(string descrizione);
}

//strategie che implementano la preparazione
public class Fritto : IPreparazioneStrategica
{
    public string Prepara(string descrizione)
    {
        return $"{descrizione} fritto in friggitrice.";
    }
}

public class AlForno : IPreparazioneStrategica
{
    public string Prepara(string descrizione)
    {
        return $"{descrizione} cotto al forno.";
    }
}

public class AllaGriglia : IPreparazioneStrategica
{
    public string Prepara(string descrizione)
    {
        return $"{descrizione} grigliato su pietra lavica.";
    }
}

//Singleton e Subject per Observer + context strategy
public class Chef
{
    //singleton
    private static Chef _istance = new();
    public static Chef istanza
    {
        get => _istance;
    }
    private Chef()
    {

    }

    //lista per observer
    private List<IObserver1> lstObs = new();

    //strategy
    private IPreparazioneStrategica _strategy;

    //impostiamo strategia di preparazione
    public void SetStrategy(IPreparazioneStrategica strategy)
    {
        _strategy = strategy;
    }

    //viene preparato il piatto in base alla strategia scelta e viene notificato l'aggiornamento a observer
    public void PreparaPiatto(IPiatto piatto)
    {
        if (_strategy == null)
        {
            Console.WriteLine("Nessuna strategia impostata.");
            return;
        }
        string messaggio = _strategy.Prepara(piatto.Descrizione());
        Notifica(messaggio);
    }

    //metodi di interfaccia subject
    public void Registra(IObserver1 o1)
    {
        lstObs.Add(o1);
    }

    public void Rimuovi(IObserver1 o1)
    {
        lstObs.Remove(o1);
    }

    public void Notifica(string messaggio)
    {
        foreach (var ob in lstObs)
        {
            ob.Aggiorna(messaggio);
        }
    }
}
#endregion

#region Observer

//interfaccia observer
public interface IObserver1
{
    public void Aggiorna(string messaggio);
}

//interfaccia subject
public interface ISubject
{
    public void Registra(IObserver1 o1);
    public void Rimuovi(IObserver1 o1);
    public void Notifica(string messaggio);
}

//concrete observer
public class Log1 : IObserver1
{
    public void Aggiorna(string messaggio)
    {
        Console.WriteLine($"Aggiornamento Log - Lo chef ha preparato {messaggio}");
    }
}

#endregion
