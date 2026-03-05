using System;

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
        List<DispositivoElettronico> dispositivi = new();

        Computer pc = new();
        pc.Modello = "Lenovo Yoga";
        dispositivi.Add(pc);

        Stampante s = new();
        s.Modello = "Stampante 3D";
        dispositivi.Add(s);

        foreach (DispositivoElettronico d in dispositivi)
        {
            Console.WriteLine(d.MostraInfo());
            Console.WriteLine(d.Accendi());
            Console.WriteLine(d.Spegni());
        }
    }

    public static void Esercizio2()
    {
        List<IPagamento> pagamenti = new();

        PagamentoCarta carta = new();
        carta.Circuito = "Revolut";
        pagamenti.Add(carta);

        PagamentoPayPal paypal = new();
        paypal.EmailUtente = "lucarossi@gmail.com";
        pagamenti.Add(paypal);

        PagamentoContanti cash = new();
        pagamenti.Add(cash);

        foreach (IPagamento ip in pagamenti)
        {
            Console.WriteLine();
            ip.MostraMetodo();
            ip.EseguiPagamento(250);
        }
    }

    public static void Esercizio3()
    {
        List<Docente> docenti = new();
        List<Corso> corsi = new();

        bool continua = true;

        while (continua)
        {
            Console.WriteLine("\nScegli opzione: ");
            Console.WriteLine("1. Aggiungi docente");
            Console.WriteLine("2. Aggiungi corso in presenza");
            Console.WriteLine("3. Aggiungi corso online");
            Console.WriteLine("4. Visualizza tutti i corsi");
            Console.WriteLine("0. Esci");

            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Docente d = new();
                    Console.WriteLine($"Nome: ");
                    d.Nome = Console.ReadLine();
                    Console.WriteLine($"Materia: ");
                    d.Materia = Console.ReadLine();
                    docenti.Add(d);
                    break;
                case 2:
                    CorsoInPresenza cp = new();
                    Console.WriteLine($"Titolo: ");
                    cp.Titolo = Console.ReadLine();
                    Console.WriteLine($"Durata ore: ");
                    cp.DurataOre = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Aula: ");
                    cp.Aula = Console.ReadLine();
                    Console.WriteLine($"Numero di posti: ");
                    cp.NumeroPosti = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Seleziona docente: ");
                    for (int i = 0; i < docenti.Count; i++)
                    {
                        Console.WriteLine($"{i}: {docenti[i].Nome}");
                    }
                    int p = int.Parse(Console.ReadLine());
                    cp.DocenteCorso = docenti[p];
                    corsi.Add(cp);
                    break;
                case 3:
                    CorsoOnline co = new();
                    Console.WriteLine($"Titolo: ");
                    co.Titolo = Console.ReadLine();
                    Console.WriteLine($"Durata ore: ");
                    co.DurataOre = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Piattaforma: ");
                    co.Piattaforma = Console.ReadLine();
                    Console.WriteLine($"Link di accesso ");
                    co.LinkAccesso = Console.ReadLine();
                    Console.WriteLine($"Seleziona docente: ");
                    for (int i = 0; i < docenti.Count; i++)
                    {
                        Console.WriteLine($"{i}: {docenti[i].Nome}");
                    }
                    int p2 = int.Parse(Console.ReadLine());
                    co.DocenteCorso = docenti[p2];
                    corsi.Add(co);
                    break;
                case 4:
                    foreach (Corso c in corsi)
                    {
                        c.StampaDettagli();
                    }
                    break;
                case 0:
                    continua = false;
                    break;
                default:
                    Console.WriteLine($"Scelta non consentita.");
                    break;
            }
        }
    }
}