class Program
{
    static void Main()
    {
        Esercizio1();
    }

    public static void Esercizio1()
    {
        Calcolatrice calcolatrice = new();
        Log log = new();
        calcolatrice.Registra(log);

        Console.WriteLine($"Inserisci un numero:");
        double n1 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Inserisci un altro numero:");
        double n2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"\nChe operazione vuoi fare?");
        Console.WriteLine($"1 - Addizione");
        Console.WriteLine($"2 - Sottrazione");
        Console.WriteLine($"3 - Moltiplicazione");
        Console.WriteLine($"4 - Divisione");
        int scelta = int.Parse(Console.ReadLine());

        switch (scelta)
        {
            case 1:
                calcolatrice.ImpostaStrategia(new SommaStrategia());

                break;
            case 2:
                calcolatrice.ImpostaStrategia(new SottrazioneStrategia());
                break;
            case 3:
                calcolatrice.ImpostaStrategia(new MoltiplicazioneStrategia());
                break;
            case 4:
                calcolatrice.ImpostaStrategia(new DivisioneStrategia());
                break;
            default:
                Console.WriteLine($"Scelta errata.");
                break;
        }
        calcolatrice.EseguiOperazione(n1, n2);
    }
}