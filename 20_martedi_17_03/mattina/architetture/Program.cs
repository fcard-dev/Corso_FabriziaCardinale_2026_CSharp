class Program
{
    static void Main()
    {
        //Esercizio1();
        //Esercizio2();
        Esercizio3();
    }


    public static void Esercizio1()
    {
        IGreeter greeter = new ConsoleGreeter();
        GreetingService service = new GreetingService(greeter);

        service.Saluta("Anna");
    }

    public static void Esercizio2()
    {
        Console.WriteLine($"\nQuanto vuoi pagare?");
        double cifra = double.Parse(Console.ReadLine());
        Console.WriteLine($"\nCome vuoi pagare?");
        Console.WriteLine($"1 - Paypal");
        Console.WriteLine($"2 - Stripe");

        int scelta = int.Parse(Console.ReadLine());

        IPaymentGateway metodo = null;
        switch (scelta)
        {
            case 1:
                metodo = new PaypalGateway();
                break;
            case 2:
                metodo = new StripeGateway();
                break;
            default:
                Console.WriteLine($"Scelta errata.");
                break;
        }
        PaymentService service = new PaymentService(metodo);
        service.Paga(cifra);
    }

    public static void Esercizio3()
    {
        Printer p = new();
        p.logger = new ConsoleLogger();
        p.Print("Prova log");
    }
}