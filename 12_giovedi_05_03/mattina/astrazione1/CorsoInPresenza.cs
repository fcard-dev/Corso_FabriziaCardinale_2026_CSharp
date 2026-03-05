public class CorsoInPresenza : Corso
{
    private string aula;
    private int numeroPosti;

    public string Aula
    {
        get => aula;
        set
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
            {
                aula = value;
            }
            else
            {
                Console.WriteLine($"Aula non valida.");
            }
        }
    }

    public int NumeroPosti
    {
        get => numeroPosti;
        set
        {
            if (value > 1)
            {
                numeroPosti = value;
            }
            else
            {
                Console.WriteLine($"Il numero di posti deve essere maggiore di 1.");
            }
        }
    }

    public override void ErogaCorso()
    {
        Console.WriteLine($"Il corso {Titolo} è nell'aula {Aula}.");

    }
    public override void StampaDettagli()
    {
        Console.WriteLine($"\nCorso: {Titolo}");
        Console.WriteLine($"Durata: {DurataOre}");
        Console.WriteLine($"Aula: {Aula}");
        Console.WriteLine($"Posti disponibili: {NumeroPosti}");
        Console.WriteLine($"Docente: {DocenteCorso.Nome}");

    }
}