using System;

class Program
{
    static ControlliAccesso controlli = new();
    static List<Dipendente> dipendenti = new();
    static Manager pManager = new Manager()
    {
        Nome = "Bruno",
        Cognome = "Rossi",
        badge = new Badge
        {
            Codice = "M01",
            IsActive = true
        }
    };

    static void Main()
    {
        bool continua = true;

        while (continua)
        {
            Console.WriteLine("\nSeleziona il tipo di accesso:");
            Console.WriteLine("1 - Manager");
            Console.WriteLine("2 - Dipendente");
            Console.WriteLine("0 - Esci");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.WriteLine($"Benvenuto {pManager.Nome}!");
                    bool manager = true;
                    while (manager)
                    {
                        Console.WriteLine("\nScegli opzione:");
                        Console.WriteLine("1 - Aggiungi dipendente");
                        Console.WriteLine("2 - Assegna badge a dipendente");
                        Console.WriteLine("3 - Visualizza log accessi");
                        Console.WriteLine("0 - Torna indietro");
                        int sceltaManager = int.Parse(Console.ReadLine());

                        switch (sceltaManager)
                        {
                            case 1:
                                InserisciDipendente();
                                break;
                            case 2:
                                AssegnaBadge();
                                break;
                            case 3:
                                controlli.RegistroAccessi();
                                break;
                            case 0:
                                manager = false;
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("\nSeleziona il tuo profilo dipendente:");
                    for (int i = 0; i < dipendenti.Count; i++)
                    {
                        string badgeInfo = dipendenti[i].badge != null ? dipendenti[i].badge.Codice : "Nessun badge";
                        Console.WriteLine($"{i + 1} - {dipendenti[i].Nome} {dipendenti[i].Cognome} ({badgeInfo})");
                    }

                    Console.Write("Numero dipendente: ");
                    int dipIdx = int.Parse(Console.ReadLine()) - 1;

                    if (dipIdx < 0 || dipIdx >= dipendenti.Count)
                    {
                        Console.WriteLine("Dipendente non valido.");
                        break;
                    }

                    Dipendente dipendenteCorrente = dipendenti[dipIdx];
                    bool dipendente = true;
                    while (dipendente)
                    {
                        Console.WriteLine("\nScegli Opzione:");
                        Console.WriteLine("1 - Entrata");
                        Console.WriteLine("2 - Uscita");
                        Console.WriteLine("3 - Visualizza log");
                        Console.WriteLine("0 - Torna indietro");

                        int sceltaDip = int.Parse(Console.ReadLine());

                        switch (sceltaDip)
                        {
                            case 1:
                                controlli.Entrata(dipendenteCorrente);
                                break;
                            case 2:
                                controlli.Uscita(dipendenteCorrente);
                                break;
                            case 3:
                                controlli.RegistroAccessi();
                                break;
                            case 0:
                                dipendente = false;
                                break;
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

    public static void InserisciDipendente()
    {
        Dipendente d = new();
        Console.WriteLine($"Nome: ");
        d.Nome = Console.ReadLine();
        Console.WriteLine($"Cognome: ");
        d.Cognome = Console.ReadLine();
        Console.WriteLine($"Turno: ");
        d.Turno = Console.ReadLine();
        dipendenti.Add(d);
        Console.WriteLine($"Dipendente aggiunto.");
    }

    public static void AssegnaBadge()
    {
        Console.WriteLine("Seleziona dipendente per assegnazione badge:");
        for (int i = 0; i < dipendenti.Count; i++)
        {
            string badgeInfo = dipendenti[i].badge != null ? dipendenti[i].badge.Codice : "Nessun badge";
            Console.WriteLine($"{i + 1} - {dipendenti[i].Nome} {dipendenti[i].Cognome} ({badgeInfo})");
        }

        Console.Write("Scegli numero dipendente: ");
        int idx = int.Parse(Console.ReadLine()) - 1;

        if (idx >= 0 && idx < dipendenti.Count)
        {
            dipendenti[idx].badge = new Badge();
            Console.Write("Inserisci codice badge: ");
            dipendenti[idx].badge.Codice = Console.ReadLine();
            dipendenti[idx].badge.IsActive = true;
            Console.WriteLine($"Badge assegnato a {dipendenti[idx].Nome} {dipendenti[idx].Cognome}");
        }
    }

}