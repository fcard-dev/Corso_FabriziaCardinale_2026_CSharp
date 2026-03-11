//Strategy
public interface IStrategiaOperazione
{
    public double Calcola(double a, double b);
}

public class SommaStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a + b;
    }
}

public class SottrazioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a - b;
    }
}

public class MoltiplicazioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a * b;
    }
}

public class DivisioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a / b;
    }
}

public class Calcolatrice : ISoggetto
{
    List<IObserver> lstObs = new();
    private IStrategiaOperazione _strategia;

    public void ImpostaStrategia(IStrategiaOperazione nuovaStrategia)
    {
        _strategia = nuovaStrategia;
    }

    public void EseguiOperazione(double a, double b)
    {
        if (_strategia == null)
        {
            Console.WriteLine("Nessuna strategia impostata.");
            return;
        }
        double result = _strategia.Calcola(a, b);
        Notifica(result);
        Console.WriteLine($"\nRisultato dell'operazione: {result}");
    }

    public void Registra(IObserver o)
    {
        lstObs.Add(o);
    }

    public void Rimuovi(IObserver o)
    {
        lstObs.Remove(o);
    }

    public void Notifica(double result)
    {
        foreach (var ob in lstObs)
        {
            ob.Aggiorna(result);
        }
    }
}

//observer
public interface IObserver
{
    public void Aggiorna(double result);
}

public interface ISoggetto
{
    public void Registra(IObserver o);
    public void Rimuovi(IObserver o);
    public void Notifica(double result);
}

public class Log : IObserver
{
    public void Aggiorna(double result)
    {
        Console.WriteLine($"Operazione effettuata - Log - {result}.");
    }
}