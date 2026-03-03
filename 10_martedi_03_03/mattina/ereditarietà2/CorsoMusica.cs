public class CorsoMusica : Corso
{
    public string Strumento;

    public CategoriaCorso categoria
    {
        get
        {
            return CategoriaCorso.Musica;
        }
    }
    public override string ToString()
    {
        return base.ToString() + $" | Strumento: {Strumento}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si tiene una prova pratica dello strumeno: {Strumento}");

    }
}