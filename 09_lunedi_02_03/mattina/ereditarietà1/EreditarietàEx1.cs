/*public class Animale
{

    protected int eta;

    public void FaiVerso()
    {
        Console.WriteLine($"l'animale fa un verso");
    }

    public virtual void Verso()
    {
        Console.WriteLine($"Questo animale emette un verso");
    }

    public void Mangia()
    {
        Console.WriteLine($"l'animale si nutre");
    }
}

public class Cane : Animale
{
    public void Scodinzola()
    {
        Console.WriteLine($"il cane scodinzola");
    }

     public override void Verso()
     {
         Console.WriteLine($"Il cane abbaia");
     } 

    public override void Verso()
    {
        base.Verso();
        Console.WriteLine($"Il cane abbaia");
    } 
}

public class Gatto : Animale
{
    public new void Mangia()
    {
        Console.WriteLine($"il gatto mangia");
    }
}

public class Elefante : Animale
{
    public void ImpostEta(int nuovaEta)
    {
        eta = nuovaEta
    }
}

public class Pogramma
{
    public static void Main()
    {
        Cane miocane = new();
        miocane.FaiVerso();
        miocane.Scodinzola();

        miocane.Verso();

        Gatto miogatto = new();
        miogatto.Mangia();
    }

}
*/