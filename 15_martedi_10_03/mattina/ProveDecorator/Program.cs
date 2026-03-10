public class Program
{
    static void Main(string[] args)
    {
        Esercizio1();
    }

    public static void Esercizio1()
    {
        IBevanda bevanda1 = new Caffe();
        IBevanda bevanda2 = new Te();

        bevanda1 = new ConCioccolato(bevanda1);
        bevanda2 = new ConLatte(bevanda2);
        bevanda1 = new ConPanna(bevanda1);

        Console.WriteLine(bevanda1.Descrizione());
        Console.WriteLine(bevanda1.Costo());

        Console.WriteLine(bevanda2.Descrizione());
        Console.WriteLine(bevanda2.Costo());
    }
}