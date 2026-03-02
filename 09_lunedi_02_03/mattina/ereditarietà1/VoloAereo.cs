public class VoloAereo
{
    private int PostiOccupati;

    public const int MaxPosti = 150;

    public int CodiceVolo;

    public int PostiLiberi 
    {
        get {return MaxPosti - PostiOccupati;}
    }

    public void EffettuaPrenotazione(int numeroPosti)
    {
        if (numeroPosti > 0 && PostiOccupati + numeroPosti <= MaxPosti)
        {
            PostiOccupati += numeroPosti;
            Console.WriteLine($"{numeroPosti} posti prenotati.");
        }
        else
        {
            Console.WriteLine($"posti disponibili insufficienti.");
        }
    }

    public void AnnullaPrenotazione(int numeroPosti)
    {
        if (numeroPosti > 0 && numeroPosti <= PostiOccupati)
        {
            PostiOccupati -= numeroPosti;
            Console.WriteLine($"{numeroPosti} rimossi.");
        }
        else
        {
            Console.WriteLine($"operazione non andata a buon fine.");
        }
    }

    public void VisualizzaStato()
    {
        Console.WriteLine($"\nVolo: {CodiceVolo}");
        Console.WriteLine($"Posti occupati: {PostiOccupati}");
        Console.WriteLine($"Posti disponibili: {PostiLiberi}");
    }
}