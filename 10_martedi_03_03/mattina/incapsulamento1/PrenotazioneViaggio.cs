class PrenotazioneViaggio
{
    private int postiPrenotati;
    private string destinazione;
    public const int MaxPosti = 20;

    public string Destinazione
    {
        get => destinazione; 
        set => destinazione = value; 
    }
    public int PostiDisponibili
    {
        get => MaxPosti - postiPrenotati; 
    }

    public int PostiPrenotati
    {
        get => postiPrenotati;
    }

    public void PrenotaPosti(int numero)
    {
        if (numero > 0 && postiPrenotati + numero <= MaxPosti)
        {
            postiPrenotati += numero;
            Console.WriteLine($"{numero} posti prenotati.");
        }
        else
        {
            Console.WriteLine($"posti non disponibili.");
        }
    }

    public void AnnullaPrenotazione(int numero)
    {
        if (numero > 0 && numero <= postiPrenotati)
        {
            postiPrenotati -= numero;
            Console.WriteLine($"{numero} rimossi.");
        }
        else
        {
            Console.WriteLine($"operazione non riuscita.");
        }
    }

    public void Recap()
    {
        Console.WriteLine($"\nDestinazione: {Destinazione}");
        Console.WriteLine($"Posti occupati: {PostiPrenotati}");
        Console.WriteLine($"Posti disponibili: {PostiDisponibili}");
    }
}