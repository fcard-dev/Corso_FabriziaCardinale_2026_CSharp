public class Corso
{
    public string NomeCorso;
    public int DurataOre;
    public string Docente;
    public List<string> Studenti = new();

    public virtual CategoriaCorso categoria {get; set;} 

    public void AggiungiStudente(string nomeStudente)
    {
        Studenti.Add(nomeStudente);
    }

    public override string ToString()
    {
        return $"Nome:{NomeCorso} | Durata: {DurataOre} | Docente: {Docente} | Studenti: {Studenti.Count}";
    }

    public virtual void MetodoSpeciale()
    {
        Console.WriteLine($"Si tiene un corso.");
    }
}