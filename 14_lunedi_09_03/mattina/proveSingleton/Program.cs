class Program
{
    static void Main(string[] args)
    {
        //Esercizio1();
        //Esercizio2();
        Esercizio3();

    }

    public static void Esempio()
    {
        var istanza1 = Singleton.Instance;

        istanza1.DoSomething();
    }

    public static void Esercizio1()
    {
        var istanza1 = Logger.GetIstanza();
        var istanza2 = Logger.GetIstanza();

        var istanza3 = Logger2.GetIstanza();
        var istanza4 = Logger2.GetIstanza();

        istanza1.ScriviMessaggio("Primo messaggio");
        istanza2.ScriviMessaggio("Secondo messaggio");

        istanza3.ScriviMessaggio("Messaggio numero 1 da Logger2");
        istanza4.ScriviMessaggio("Messaggio numero 2 da Logger2");

        if (istanza1 == istanza2)
        {
            Console.WriteLine($"Stessa istanza per Logger1");
        }
        else
        {
            Console.WriteLine($"Istanza diversa per Logger1");
        }

        if (!(istanza3 == istanza4))
        {
            Console.WriteLine($"Differente istanza per Logger2");
        }
        else
        {
            Console.WriteLine($"Uguale istanza per Logger2");
        }
    }

    public static void Esercizio2()
    {
        var conf1 = ConfigurazioneSistema.Istance;
        var conf2 = ConfigurazioneSistema.Istance;

        conf1.Imposta("Nome", "Luigi");
        conf1.Imposta("Lingua", "Italiano");
        Console.WriteLine($"{conf1.Leggi("Nome")}");
        Console.WriteLine($"{conf1.Leggi("Lingua")}");

        conf2.Imposta("Città", "Bologna");
        conf2.Imposta("Nazione", "Italia");
        Console.WriteLine($"{conf2.Leggi("Città")}");
        Console.WriteLine($"{conf2.Leggi("Nazione")}");

        Console.WriteLine($"\nConfronto istanze:");

        if (conf1 == conf2)
        {
            Console.WriteLine($"Stessa istanza");
        }
        else
        {
            Console.WriteLine($"Istanza diversa");
        }

        conf1.StampaTutte();
    }

    public static void Esercizio3()
    {
        bool continua = true;
        while (continua)
        {
            Console.WriteLine("\nSeleziona opzione:");
            Console.WriteLine("1 - Aggiungi log");
            Console.WriteLine("2 - Confronta istanze log");
            Console.WriteLine("3 - Mostra log");
            Console.WriteLine("0 - Esci");
            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                Console.WriteLine($"Inserisci messaggio: ");
                string messaggio = Console.ReadLine();
                Logger3.Istance3.Log(messaggio);
                Console.WriteLine($"Messaggio inserito.");
                    break;
                case 2:
                    var log1 = Logger3.Istance3;
                    log1.Log("log 1");

                    var log2 = Logger3.Istance3;
                    log2.Log("log 2");

                    Console.WriteLine($"\nConfronto istanze:");

                    Console.WriteLine(log1 == log2 ? "Stessa istanza" : "Istanza diversa");

                    break;
                case 3:
                    Logger3.Istance3.StampaTutto();
                    break;
                case 0:
                    continua = false;
                    break;
                default:
                    Console.WriteLine($"Scelta non valida");
                    break;
            }
        }
    }

}