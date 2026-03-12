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

    public static void Esercizio2()
    {
        PaymentContext context = new();

        Console.WriteLine($"\nScegli metodo di pagamento");
        Console.WriteLine($"1 - Carta di credito");
        Console.WriteLine($"2 - Paypal");
        Console.WriteLine($"3 - Bitcoin");

        int sceltaPagamento = int.Parse(Console.ReadLine());

        IPaymentStrategy strategy = PaymentFactory.CreaPagamento(sceltaPagamento);

        context.SetStrategy(strategy);

        context.Pay(90);
    }

    public static void Esercizio3()
    {
        //singleton + context strategy
        Chef chef = Chef.istanza;
        //observer
        Log1 log1 = new();
        //aggiungo l'observer allo chef
        chef.Registra(log1);

        IPiatto piatto = null;

        //scelgo il piatto e lo creo con il factory
        Console.WriteLine("\nScegli piatto base:");
        Console.WriteLine("1 - Pizza");
        Console.WriteLine("2 - Hamburger");
        Console.WriteLine("3 - Insalata");
        Console.Write("Scelta: ");
        int scelta = int.Parse(Console.ReadLine());

        switch (scelta)
        {
            case 1:
                piatto = PiattoFactory.Crea("pizza");
                break;
            case 2:
                piatto = PiattoFactory.Crea("hamburger");
                break;
            case 3:
                piatto = PiattoFactory.Crea("insalata");
                break;
            default:
                Console.WriteLine($"Scelta errata.");
                break;
        }

        //aggiungo ingredienti con decorator
        bool ingredienti = true;
        while (ingredienti)
        {
            Console.WriteLine("\nSeleziona ingredienti da aggiungere:");
            Console.WriteLine("1 - Formaggio");
            Console.WriteLine("2 - Bacon");
            Console.WriteLine("3 - Salsa");
            Console.WriteLine("0 - Esci");
            Console.Write("Scelta: ");
            int sceltaIngr = int.Parse(Console.ReadLine());

            switch (sceltaIngr)
            {
                case 1:
                    piatto = new ConFormaggio(piatto);
                    break;
                case 2:
                    piatto = new ConBacon(piatto);
                    break;
                case 3:
                    piatto = new ConSalsa(piatto);
                    break;
                case 0:
                    ingredienti = false;
                    break;
                default:
                    Console.WriteLine($"Scelta non valida");
                    break;
            }
        }

        //scelgo preparazione tramite strategy
        Console.WriteLine("\nChe cottura preferisci?");
        Console.WriteLine("1 - Fritto");
        Console.WriteLine("2 - Al forno");
        Console.WriteLine("3 - Alla griglia");
        Console.Write("Scelta: ");
        int sceltaCottura = int.Parse(Console.ReadLine());

        IPreparazioneStrategica strategy = null;

        switch (sceltaCottura)
        {
            case 1:
                strategy = new Fritto();
                break;
            case 2:
                strategy = new AlForno();
                break;
            case 3:
                strategy = new AllaGriglia();
                break;
            default:
                Console.WriteLine($"Scelta non valida");
                break;
        }
        chef.SetStrategy(strategy);
        Console.WriteLine($"\n{piatto.Descrizione()}");
        chef.PreparaPiatto(piatto);
    }
}