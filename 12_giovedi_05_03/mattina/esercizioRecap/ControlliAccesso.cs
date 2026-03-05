using System.Runtime.CompilerServices;

public class ControlliAccesso
{
    private List<string> _accessi = new();

    public void Entrata(Persona p)
    {
        string log = "";
        if (p.badge != null && p.badge.IsActive)
        {
            if (p is Manager)
            {
                log = $"{p.Nome}, {p.Cognome} (Manager) è entrato.";
            }
            else if (p is Dipendente)
            {
                log = $"{p.Nome}, {p.Cognome} (Dipendente) è entrato.";
            }
            _accessi.Add(log);
        }
        else
        {
            log = $"{p.Nome}, {p.Cognome} Accesso non consentito per badge non attivo.";
            _accessi.Add(log);
        }
    }

    public void Uscita(Persona p)
    {
        string log = "";
        if (p.badge != null && p.badge.IsActive)
        {
            if (p is Manager)
            {
                log = $"{p.Nome}, {p.Cognome} (Manager) è uscito.";
            }
            else if (p is Dipendente)
            {
                log = $"{p.Nome}, {p.Cognome} (Dipendente) è uscito.";
            }
            _accessi.Add(log);
        }
        else
        {
            log = $"{p.Nome}, {p.Cognome} Uscita non consentito per badge non attivo.";
            _accessi.Add(log);
        }
    }

    public void RegistroAccessi()
    {
        Console.WriteLine($"\n=====Accessi=====");
        foreach (var a in _accessi)
        {
            Console.WriteLine(a);
        }
    }
}