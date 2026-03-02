public class Libro
{
    public string Titolo;
    public string Autore;
    public int AnnoPubblicazione;

    public override string ToString()
    {
        return $"'{Titolo}' di {Autore} ({AnnoPubblicazione})";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Libro altro)
        {
            return Titolo == altro.Titolo && Autore == altro.Autore;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Titolo, Autore);
    }
}