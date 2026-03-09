public interface IShape
{
    public void Draw();
}

public class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine($"Quadrato disegnato.");
    }
}

public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine($"Cerchio disegnato.");
    }
}