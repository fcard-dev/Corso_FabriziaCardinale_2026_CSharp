using System;

class Program
{
    static List<Corso> corsi = new();
    static void Main()
    {
        Scuola();
    }

    public static void Scuola()
    {
        bool continua = true;
        while (continua)
        {
            Console.WriteLine($"\nScegli tra le seguenti opzioni:");
            Console.WriteLine($"[1] Aggiungi un corso di Musica");
            Console.WriteLine($"[2] Aggiungi un corso di Pittura");
            Console.WriteLine($"[3] Aggiungi un corso di Danza");
            Console.WriteLine($"[4] Aggiungi studente a un corso (con selezione per indice)");
            Console.WriteLine($"[5] Visualizza tutti i corsi");
            Console.WriteLine($"[6] Cerca corsi per nome docente");
            Console.WriteLine($"[7] Esegui metodo speciale di un corso (selezionato per indice)");
            Console.WriteLine($"[0] Esci");

            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    AggiuntaCorsoMusica();
                    break;
                case 2:
                    AggiuntaCorsoPittura();
                    break;
                case 3:
                    AggiuntaCorsoDanza();
                    break;
                case 4:
                    AggiuntaStudente();
                    break;
                case 5:
                    ElencoCorsi();
                    break;
                case 6:
                    CercaCorsi();
                    break;
                case 7:
                    EseguiMetodoSpeciale();
                    break;
                case 0:
                    continua = false;
                    Console.WriteLine($"=====Uscita in corso.=====");
                    break;
                default:
                    Console.WriteLine($"=====Scelta non consentita.=====");
                    break;
            }
        }
    }

    public static void AggiuntaCorsoMusica()
    {
        Console.WriteLine($"Inserisci corso di musica: ");
        string nomeCorso = Console.ReadLine();
        Console.WriteLine($"Inserisci durata: ");
        int durataOre = int.Parse(Console.ReadLine());
        Console.WriteLine($"Inserisci docente: ");
        string docente = Console.ReadLine();
        Console.WriteLine($"Inserisci strumento: ");
        string strumento = (Console.ReadLine());
        CorsoMusica corsoMusica = new CorsoMusica
        {
            NomeCorso = nomeCorso,
            DurataOre = durataOre,
            Docente = docente,
            Strumento = strumento
        };
        corsi.Add(corsoMusica);
        Console.WriteLine($"=====Corso di musica inserito.=====");
    }

    public static void AggiuntaCorsoPittura()
    {
        Console.WriteLine($"Inserisci corso di pittura: ");
        string nomeCorso = Console.ReadLine();
        Console.WriteLine($"Inserisci durata: ");
        int durataOre = int.Parse(Console.ReadLine());
        Console.WriteLine($"Inserisci docente: ");
        string docente = Console.ReadLine();
        Console.WriteLine($"Inserisci tecnica: ");
        string tecnica = (Console.ReadLine());
        CorsoPittura corsoPittura = new CorsoPittura
        {
            NomeCorso = nomeCorso,
            DurataOre = durataOre,
            Docente = docente,
            Tecnica = tecnica
        };
        corsi.Add(corsoPittura);
        Console.WriteLine($"=====Corso di pittura inserito.=====");
    }

    public static void AggiuntaCorsoDanza()
    {
        Console.WriteLine($"Inserisci corso di danza: ");
        string nomeCorso = Console.ReadLine();
        Console.WriteLine($"Inserisci durata: ");
        int durataOre = int.Parse(Console.ReadLine());
        Console.WriteLine($"Inserisci docente: ");
        string docente = Console.ReadLine();
        Console.WriteLine($"Inserisci stile: ");
        string stile = (Console.ReadLine());
        CorsoDanza corsoDanza = new CorsoDanza
        {
            NomeCorso = nomeCorso,
            DurataOre = durataOre,
            Docente = docente,
            Stile = stile
        };
        corsi.Add(corsoDanza);
        Console.WriteLine($"=====Corso di danza inserito.=====");
    }

    public static void AggiuntaStudente()
    {
        ElencoCorsi();
        Console.WriteLine($"\nSeleziona l'indice del corso in cui vuoi aggiungere lo studente: ");
        int indiceCorso = int.Parse(Console.ReadLine());

        if (indiceCorso >= 0 && indiceCorso < corsi.Count)
        {
            Console.WriteLine($"Inserisci nome studente: ");
            string nomeStudente = Console.ReadLine();

            corsi[indiceCorso].AggiungiStudente(nomeStudente);

            Console.WriteLine($"Studente inserito.");
        }
        else
        {
            Console.WriteLine($"Indice errato.");
        }
    }

    public static void ElencoCorsi()
    {
        Console.WriteLine($"\nCorsi di Musica: ");
        for (int i = 0; i < corsi.Count; i++)
        {
            if (corsi[i].categoria == CategoriaCorso.Musica)
            {
                Console.WriteLine($"[{i}] - {corsi[i]}");
            }
        }

        Console.WriteLine($"\nCorsi di Pittura: ");
        for (int i = 0; i < corsi.Count; i++)
        {
            if (corsi[i].categoria == CategoriaCorso.Pittura)
            {
                Console.WriteLine($"[{i}] - {corsi[i]}");
            }
        }

        Console.WriteLine($"\nCorsi di Danza: ");
        for (int i = 0; i < corsi.Count; i++)
        {
            if (corsi[i].categoria == CategoriaCorso.Danza)
            {
                Console.WriteLine($"[{i}] - {corsi[i]}");
            }
        }
    }

    public static void CercaCorsi()
    {
        Console.WriteLine($"Inserisci nome docente: ");
        string docenteRicerca = Console.ReadLine();
        bool ricerca = false;

        Console.WriteLine($"\nCorsi appartenenti al docente {docenteRicerca}");
        foreach (var c in corsi)
        {
            if (c.Docente == docenteRicerca)
            {
                Console.WriteLine($"{c}");
                ricerca = true;
            }
        }
        if (!ricerca)
        {
            Console.WriteLine($"Nessun corso trovato per il docente {docenteRicerca}.");
        }
    }

    public static void EseguiMetodoSpeciale()
    {
        ElencoCorsi();
        Console.WriteLine($"\nSeleziona l'indice del corso: ");
        int indiceCorso = int.Parse(Console.ReadLine());

        if (indiceCorso >= 0 && indiceCorso < corsi.Count)
        {
            corsi[indiceCorso].MetodoSpeciale();
        }
        else
        {
            Console.WriteLine($"Indice errato.");
        }
    }
}