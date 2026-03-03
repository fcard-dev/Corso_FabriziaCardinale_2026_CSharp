using System;

class Program
{
    static void Main()
    {
        //  Esercizio1();
        Esercizio2();
    }


    public static void Esercizio1()
    {
        List<PrenotazioneViaggio> viaggi = new();

        bool continua = true;

        while (continua)
        {
            PrenotazioneViaggio viaggio = new();

            Console.WriteLine($"Inserire destinazione:");
            viaggio.Destinazione = Console.ReadLine();

            bool viaggioScelto = true;
            while (viaggioScelto)
            {
                Console.WriteLine($"\nVolo con destinazione {viaggio.Destinazione}");
                Console.WriteLine($"Che operazione vuoi effettuare?");
                Console.WriteLine($"[1] Prenota posti");
                Console.WriteLine($"[2] Annulla prenotazione");
                Console.WriteLine($"[0] Esci");

                int scelta = int.Parse(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        Console.WriteLine($"Quanti posti vuoi prenotare? ");
                        int postiDaPrenotare = int.Parse(Console.ReadLine());
                        viaggio.PrenotaPosti(postiDaPrenotare);
                        viaggio.Recap();
                        break;
                    case 2:
                        Console.WriteLine($"Quanti posti vuoi cancellare? ");
                        int postiDaAnnullare = int.Parse(Console.ReadLine());
                        viaggio.AnnullaPrenotazione(postiDaAnnullare);
                        viaggio.Recap();
                        break;
                    case 0:
                        viaggioScelto = false;
                        break;
                    default:
                        Console.WriteLine($"=====Scelta errata.=====");
                        break;
                }
            }
            viaggi.Add(viaggio);
            Console.WriteLine($"Vuoi effettuare una prenotazione per un'altra destinazione? S/N");
            string risposta = Console.ReadLine();

            if (risposta != "S")
            {
                continua = false;
            }
        }
        Console.WriteLine($"\n=====Riepilogo totale=====");
        foreach (var v in viaggi)
        {
            v.Recap();
        }
    }

    public static void Esercizio2()
    {
        List<Soldato> soldati = new();
        bool continua = true;

        while (continua)
        {
            Console.WriteLine($"\nScegli un opzione:");
            Console.WriteLine($"[1] Aggiungi Fante");
            Console.WriteLine($"[2] Aggiungi Artigliere");
            Console.WriteLine($"[3] Visualizza tutti i soldati con relativa descrizione");
            Console.WriteLine($"[0] Esci");

            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.WriteLine($"Inserisci il nome del fante: ");
                    string nomeFante = Console.ReadLine();
                    Console.WriteLine($"Inserisci il grado del fante: ");
                    string gradoFante = Console.ReadLine();
                    Console.WriteLine($"Inserisci gli anni di servizio del fante: ");
                    int anniFante = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Inserisci l'arma del fante: ");
                    string armaFante = Console.ReadLine();
                    Fante fante = new Fante
                    {
                        Nome = nomeFante,
                        Grado = gradoFante,
                        AnniServizio = anniFante,
                        Arma = armaFante
                    };
                    soldati.Add(fante);
                    Console.WriteLine($"=====Fante inserito.=====");
                    break;
                case 2:
                    Console.WriteLine($"Inserisci il nome dell'artigliere: ");
                    string nomeArtigliere = Console.ReadLine();
                    Console.WriteLine($"Inserisci il grado dell'artigliere: ");
                    string gradoArtigliere = Console.ReadLine();
                    Console.WriteLine($"Inserisci gli anni di servizio dell'artigliere: ");
                    int anniArtigliere = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Inserisci il calibro dell'artigliere: ");
                    int calibroArtigliere = int.Parse(Console.ReadLine());
                    Artigliere artigliere = new Artigliere
                    {
                        Nome = nomeArtigliere,
                        Grado = gradoArtigliere,
                        AnniServizio = anniArtigliere,
                        Calibro = calibroArtigliere
                    };
                    soldati.Add(artigliere);
                    Console.WriteLine($"=====Artigliere inserito.=====");
                    break;
                case 3:
                    Console.WriteLine($"\n=====Riepilogo Fanti=====");
                    foreach (var s in soldati)
                    {
                        if (s is Fante)
                        {
                            Console.WriteLine(s.Descrizione());
                        }
                    }

                    Console.WriteLine($"\n=====Riepilogo Artiglieri=====");
                    foreach (var s in soldati)
                    {
                        if (s is Artigliere)
                        {
                            Console.WriteLine(s.Descrizione());
                        }
                    }
                    break;
                case 0:
                    continua = false;
                    break;
                default:
                    Console.WriteLine($"=====Scelta errata.=====");
                    break;
            }
        }
    }
}