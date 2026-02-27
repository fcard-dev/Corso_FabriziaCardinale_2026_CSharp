public class Studente
{
    public string? Nome;
    public int Matricola;
    public double MediaVoti;

    public void Descrivi()
    {
        Console.WriteLine($"{Nome} con matricola {Matricola} ha media {MediaVoti}");
    }
}