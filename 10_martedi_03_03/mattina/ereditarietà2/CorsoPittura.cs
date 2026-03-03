public class CorsoPittura : Corso
{
public string Tecnica;

 public CategoriaCorso categoria
    {
        get
        {
            return CategoriaCorso.Pittura;
        }
    }
     public override string ToString()
    {
         return base.ToString() + $" | Tecnica: {Tecnica}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si lavora su una tela con tecnica: {Tecnica}");
        
    }
}