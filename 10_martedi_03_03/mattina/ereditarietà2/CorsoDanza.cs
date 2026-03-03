public class CorsoDanza : Corso
{
    public string Stile;

 public CategoriaCorso categoria
    {
        get
        {
            return CategoriaCorso.Danza;
        }
    }
     public override string ToString()
    {
         return base.ToString() + $" | Stile: {Stile}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Esecuzione coreografia nello stile: {Stile}");
    }
}