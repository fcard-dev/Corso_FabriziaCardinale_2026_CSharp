using System;

class Program
{
    static List<Animale> animali = new();
    static void Main()
    {
        Mucca mucca = new Mucca("Carolina", 3, true);
        Gallina gallina = new Gallina("Antonia", 5, false);
        Pecora pecora = new Pecora("Gertrude", 8, "Rossa");
        Maiale maiale = new Maiale("Alberto", 1, 10.5);

        animali.Add(mucca);
        animali.Add(gallina);
        animali.Add(pecora);
        animali.Add(maiale);

        bool continua = true;
        while (continua)
        {
            Console.WriteLine("\nSeleziona opzione:");
            Console.WriteLine("1 - Inserisci animale");
            Console.WriteLine("2 - Cancella animale");
            Console.WriteLine("3 - Modifica animale");
            Console.WriteLine("4 - Visualizza animali");
            Console.WriteLine("5 - Visualizza i versi");
            Console.WriteLine("0 - Esci");
            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    InserisciAnimale();
                    break;
                case 2:
                //    CancellaAnimale();
                    break;
                case 3:
                 //   ModificaAnimale();
                    break;
                case 4:
                    VisualizzaAnimali();
                    break;
                case 5:
                    VisualizzaVersi();
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

    public static void InserisciAnimale()
    {
        Console.WriteLine($"\nChe Animale vuoi inserire?");
        Console.WriteLine("1 - Mucca");
        Console.WriteLine("2 - Gallina");
        Console.WriteLine("3 - Pecora");
        Console.WriteLine("4 - Maiale");
        int tipoAnimale = int.Parse(Console.ReadLine());

        Console.WriteLine($"Inserisci nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine($"Inserisci età: ");
        int eta = int.Parse(Console.ReadLine());

        switch (tipoAnimale)
        {
            case 1:
                Console.WriteLine($"Ha fatto il latte? S/N: ");
                bool latte = Console.ReadLine().ToUpper() == "S";
                animali.Add(new Mucca(nome, eta, latte));
                break;
            case 2:
                Console.WriteLine($"Ha fatto le uova? S/N: ");
                bool uova = Console.ReadLine().ToUpper() == "S";
                animali.Add(new Gallina(nome, eta, uova));
                break;
            case 3:
                Console.WriteLine($"Colore della lana: ");
                string lana = Console.ReadLine();
                animali.Add(new Pecora(nome, eta, lana));
                break;
            case 4:
                Console.WriteLine($"Inserisci peso: ");
                double peso = double.Parse(Console.ReadLine());
                animali.Add(new Maiale(nome, eta, peso));
                break;
            default:
                Console.WriteLine($"Animale non valido.");
                break;
        }


    }

    public static void CancellaAnimale()
    {

    }

    public static void ModificaAnimale()
    {

    }

    public static void VisualizzaAnimali()
    {
        Console.WriteLine($"\nMucche");
        foreach (var a in animali)
        {
            if (a is Mucca)
            {
                Console.WriteLine(a.MostraInfo());
            }
        }
        Console.WriteLine($"\nGalline");
        foreach (var a in animali)
        {
            if (a is Gallina)
            {
                Console.WriteLine(a.MostraInfo());
            }
        }
        Console.WriteLine($"\nPecore");
        foreach (var a in animali)
        {
            if (a is Pecora)
            {
                Console.WriteLine(a.MostraInfo());
            }
        }
        Console.WriteLine($"\nMaiali");
        foreach (var a in animali)
        {
            if (a is Maiale)
            {
                Console.WriteLine(a.MostraInfo());
            }
        }
    }

    public static void VisualizzaVersi()
    {
        Console.WriteLine($"\nVersi: ");
        foreach (var a in animali)
        {
            a.Verso();
        }
    }

}