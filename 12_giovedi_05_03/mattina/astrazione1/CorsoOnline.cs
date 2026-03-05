public class CorsoOnline : Corso
{
    private string piattaforma;
    private string linkAccesso;

    public string Piattaforma
    {
        get => piattaforma;
        set
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
            {
                piattaforma = value;
            }
            else
            {
                Console.WriteLine($"Piattaforma non valida.");
            }
        }
    }

    public string LinkAccesso
    {
        get => linkAccesso;
        set
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
            {
                linkAccesso = value;
            }
            else
            {
                Console.WriteLine($"Link non valido.");
            }
        }
    }

    public override void ErogaCorso()
    {
        Console.WriteLine($"Il corso {Titolo} è sulla piattaforma {Piattaforma} con il link {LinkAccesso}.");

    }
    public override void StampaDettagli()
    {
        Console.WriteLine($"\nCorso: {Titolo}");
        Console.WriteLine($"Durata: {DurataOre} ore");
        Console.WriteLine($"Piattaforma: {Piattaforma}");
        Console.WriteLine($"Link di accesso: {LinkAccesso}");
        Console.WriteLine($"Docente: {DocenteCorso.Nome}");
    }
}