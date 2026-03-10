class Programma
{
    static void Main()
    {
        //Esercizio1();
        //Esercizio2();
        Esercizio3();
    }

    public static void Esercizio1()
    {
        CentroMeteo centroMeteo = new();
        DisplayConsole displayConsole = new();
        DisplayMobile displayMobile = new();

        bool continua = true;
        bool displayC = false;
        bool displayM = false;

        while (continua)
        {
            Console.WriteLine("\nSeleziona opzione:");
            Console.WriteLine("1 - Registra display console");
            Console.WriteLine("2 - Registra display mobile");
            Console.WriteLine("3 - Rimuovi display console");
            Console.WriteLine("4 - Rimuovi display mobile");
            Console.WriteLine("5 - Aggiorna dati");
            Console.WriteLine("0 - Esci");
            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    centroMeteo.Registra(displayConsole);
                    displayC = true;
                    Console.WriteLine($"Display console aggiunto");
                    break;
                case 2:
                    centroMeteo.Registra(displayMobile);
                    displayM = true;
                    Console.WriteLine($"Display mobile aggiunto");
                    break;
                case 3:
                    centroMeteo.Rimuovi(displayConsole);
                    displayC = false;
                    Console.WriteLine($"Display console rimosso");
                    break;
                case 4:
                    centroMeteo.Rimuovi(displayMobile);
                    displayM = false;
                    Console.WriteLine($"Display mobile rimosso");
                    break;
                case 5:
                    Console.WriteLine($"\nInserisci dati meteo:");
                    string datiMeteo = Console.ReadLine();
                    centroMeteo.AggiornaMeteo(datiMeteo);
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

    public static void Esercizio2()
    {
        NewsAgency agency = NewsAgency.Istanza;

        MobileApp mobile = new();
        EmailClient email = new();

        agency.Registra(mobile);
        agency.Registra(email);

        bool continua = true;

        while (continua)
        {
            Console.WriteLine("\nSeleziona opzione:");
            Console.WriteLine("1 - Inserisci news");
            Console.WriteLine("0 - Esci");
            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.WriteLine($"\nInserisci nuova notizia:");
                    string notizia = Console.ReadLine();
                    Console.WriteLine($"\nNotizia aggiornata.");
                    agency.News = notizia;
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

    public static void Esercizio3()
    {
        GestoreCreazioneUtente gCU = GestoreCreazioneUtente.Istanza;

        ModuloLog mLog = new();
        ModuloMarketing mMark = new();

        gCU.Registra(mLog);
        gCU.Registra(mMark);

        bool continua = true;

        while (continua)
        {
            Console.WriteLine("\nSeleziona opzione:");
            Console.WriteLine("1 - Inserisci nome");
            Console.WriteLine("0 - Esci");
            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    bool altriNomi = true;
                    while (altriNomi)
                    {
                        Console.WriteLine($"\nInserisci nuovo nome:");
                        string nome = Console.ReadLine();
                        Console.WriteLine($"\nNome inserito.");
                        gCU.CreaUtente(nome);

                        Console.WriteLine($"\nVuoi creare altri nomi? S/N");
                        string risp = Console.ReadLine().ToLower();
                        if(risp != "s")
                        {
                            altriNomi = false;
                        }
                    }
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