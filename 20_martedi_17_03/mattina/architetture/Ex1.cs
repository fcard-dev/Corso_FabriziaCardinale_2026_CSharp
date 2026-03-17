public interface IGreeter
{
    void Greet(string nome);
}

public class ConsoleGreeter : IGreeter
{
    public void Greet(string nome)
    {
        Console.WriteLine($"Benvenuto {nome}");
    }
}

public class GreetingService
{
    private readonly IGreeter _greeter;

    public GreetingService(IGreeter greeter)
    {
        _greeter = greeter;
    }

    public void Saluta(string nome)
    {
        _greeter.Greet(nome);
    }
}