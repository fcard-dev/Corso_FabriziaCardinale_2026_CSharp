using System;

class Program
{
    static void Main()
    {
        Esercizio1();
        Esercizio2();
        Esercizio3();
    }

    public static void Esercizio1()
    {
        //a. Crea un Dictionary<string, string> dove la chiave è il nome e il valore è il numero di telefono.
        Dictionary<string, string> rubrica = new();

        //b. Fa inserire 3 coppie nome-numero da tastiera.
        while (rubrica.Count() < 3)
        {
            Console.WriteLine($"inserisci nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci numero di telefono");
            string numero = Console.ReadLine();
            rubrica.Add(nome, numero);
        }

        //c. Stampa tutta la rubrica.
        Console.WriteLine($"Hai inserito i seguenti contatti: ");
        foreach (var contatto in rubrica)
        {
            Console.WriteLine($"Nome: {contatto.Key} - Numero: {contatto.Value}");
        }
    }

    public static void Esercizio2()
    {
        // a. Chiede all’utente di inserire una frase.
        Console.WriteLine($"Inserisci una frase: ");
        string frase = Console.ReadLine();

        //b. Divide la frase in parole (separate da spazio).
        string[] parole = frase.Split(' ');

        //c. Usa un Dictionary<string, int> per contare quante volte compare ciascuna parola.
        Dictionary<string, int> ps = new();

        foreach (string p in parole)
        {
            if (ps.ContainsKey(p))
            {
                ps[p]++;
            }
            else
            {
                ps.Add(p, 1);
            }
        }

        //d. Stampa ogni parola con la relativa frequenza.
        foreach (var p in ps)
        {
            Console.WriteLine(p.Key + " " + p.Value);
        }
    }

    public static void Esercizio3()
    {
        //a. Gestisce un Dictionary<string, int> dove la chiave è il nome di un prodotto e il valore è la quantità disponibile.
        Dictionary<string, int> magazzino = new();
        bool continua = true;

        //b. Il programma deve permettere con un menu:
        while (continua)
        {
            Console.WriteLine($"Magazzino:");
            Console.WriteLine($"1-Aggiungi/Aggiorna prodotto. ");
            Console.WriteLine($"2-Rimuovi prodotto.");
            Console.WriteLine($"3-Ricerca prodotto. ");
            Console.WriteLine($"4-Mostra inventario. ");
            Console.WriteLine($"5-Esci. ");

            int scelta1 = int.Parse(Console.ReadLine());

            switch (scelta1)
            {

                //i. Aggiungere un nuovo prodotto (o aumentare o diminuire la quantità se esiste già).
                case 1:
                    Console.WriteLine($"Inserisci prodotto nel magazzino: ");
                    string prodotto = Console.ReadLine();

                    if (magazzino.ContainsKey(prodotto))
                    {
                        Console.WriteLine($"Prodotto già presente. Scegli se: ");
                        Console.WriteLine($"1-Aumenta quantità. ");
                        Console.WriteLine($"2-Diminuisci quantità. ");
                        int s = int.Parse(Console.ReadLine());

                        Console.WriteLine($"In quante quantità? ");
                        int q = int.Parse(Console.ReadLine());

                        if (s == 1)
                        {
                            magazzino[prodotto] += q;
                            Console.WriteLine($"Quantità aumentata!");

                        }
                        else if (s == 2)
                        {
                            if (q < magazzino[prodotto])
                            {
                                magazzino[prodotto] -= q;
                                Console.WriteLine($"Quantità diminuita!");

                            }
                            else
                            {
                                Console.WriteLine($"Quantità non valida");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"In quante quantità?");
                        int quantita = int.Parse(Console.ReadLine());
                        magazzino.Add(prodotto, quantita);
                        Console.WriteLine($"Prodotto inserito!");

                    }
                    break;

                //ii. Rimuovere un prodotto dal magazzino.
                case 2:
                    Console.WriteLine($"Rimuovi prodotto dal magazzino: ");
                    prodotto = Console.ReadLine();

                    if (magazzino.ContainsKey(prodotto))
                    {
                        magazzino.Remove(prodotto);
                        Console.WriteLine($"Prodotto rimosso.");

                    }
                    else
                    {
                        Console.WriteLine($"Prodotto non trovato.");
                    }
                    break;

                //iii. Cercare un prodotto e mostrare la quantità.
                case 3:
                    Console.WriteLine($"Ricerca prodotto: ");
                    prodotto = Console.ReadLine();

                    if (magazzino.ContainsKey(prodotto))
                    {
                        Console.WriteLine($"{magazzino[prodotto]}");
                    }
                    else
                    {
                        Console.WriteLine($"Prodotto non trovato.");
                    }
                    break;

                //iv. Stampare l’inventario completo.
                case 4:
                    foreach (var p in magazzino)
                    {
                        Console.WriteLine($"Prodotto: {p.Key} - Quantità: {p.Value}");
                    }
                    break;

                //c. Il menu deve ripetersi finché l’utente non sceglie “Esci”
                case 5:
                    continua = false;
                    break;
            }
        }
    }
}