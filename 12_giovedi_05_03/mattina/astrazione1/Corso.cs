public abstract class Corso
{
    private string titolo;
    private int durataOre;
    public Docente DocenteCorso;

    public string Titolo
    {
        get => titolo;
        set
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
            {
                titolo = value;
            }
            else
            {
                Console.WriteLine($"Titolo non valido.");
            }
        }
    }

    public int DurataOre
    {
        get => durataOre;
        set
        {
            if (value > 0)
            {
                durataOre = value;
            }
            else
            {
                Console.WriteLine($"La durata deve essere maggiore di 0.");
            }
        }
    }

    public abstract void ErogaCorso();
    public abstract void StampaDettagli();
}