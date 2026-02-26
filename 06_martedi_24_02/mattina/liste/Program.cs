using System;

class Program
{
    static void Main()
    {
        /*Scrivi un programma che:
            a. Crea una lista di interi vuota.
            b. Chiede all’utente di inserire 5 numeri interi.
            c. Aggiunge i numeri nella lista.
            d. Chiede e rimuove uno o più numeri dalla lista.
            e. Stampa tutti i numeri presenti in lista.*/
        List<int> numeri = new();

        while (numeri.Count < 5)
        {
            Console.WriteLine($"Inserisci un numero intero: ");
            int n = int.Parse(Console.ReadLine());
            numeri.Add(n);
        }

        bool continua = true;
        while (continua && numeri.Count > 0)
        {
            Console.WriteLine($"Vuoi rimuovere numeri dalla lista? S/N ");
            string scelta = Console.ReadLine();

            if (scelta == "S")
            {
                Console.WriteLine($"Inserisci il numero da rimuovere: ");
                int n = int.Parse(Console.ReadLine());

                if (numeri.Contains(n))
                {
                    numeri.Remove(n);
                    Console.WriteLine($"{n} rimosso dalla lista.");
                }
                else
                {
                    Console.WriteLine($"Numero non presene nella lista.");
                }
            }
            else
            {
                continua = false;
            }

            Console.WriteLine($"La lista contiene: ");
            foreach (int num in numeri)
            {
                Console.WriteLine(num);
            }
        }
        /*Scrivi un programma che:
            a. Genera una lista di 10 numeri casuali tra 1 e 100.
            b. Stampa la lista.
            c. Chiede all’utente un numero da cercare.
            d. Controlla se il numero è presente nella lista e stampa la posizione (indice), oppure un messaggio se non trovato.
            e. Restituisce tutti i numeri pari (quanti e quali sono).*/

        Console.WriteLine($"_______________________________");

        List<int> numeri2 = new();
        Random r = new();
        int pari = 0;

        while (numeri2.Count < 10)
        {
            int numeriRandom = r.Next(1, 101);
            numeri2.Add(numeriRandom);
        }

        foreach (int i in numeri2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine($"Inserisci un numero da cercare: ");
        int numeroCercato = int.Parse(Console.ReadLine());
        int posizione = numeri2.IndexOf(numeroCercato);

        if (numeri2.Contains(numeroCercato))
        {
            Console.WriteLine($"Il numero selezionato si trova in posizione {posizione}");
        }
        else
        {
            Console.WriteLine($"Numero non trovato.");
        }

        Console.WriteLine($"Numeri pari: ");
        foreach (int i in numeri2)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                pari++;
            }
        }
        Console.WriteLine($"Il totale dei numeri pari è {pari}");

        /*Scrivi un programma che:
            a. Crea una lista di interi con almeno 15 numeri casuali tra 1 e 20 (quindi con possibili duplicati).
            b. Stampa la lista originale.
            c. Rimuove i duplicati mantenendo solo i valori unici.
            d. Ordina la lista in ordine crescente .
            e. Stampa la lista finale senza duplicati e ordinata.*/
        Console.WriteLine($"_______________________________");
        List<int> numEx3 = new();
        Random r3 = new();

        while (numEx3.Count < 15)
        {
            int numC = r3.Next(1, 21);
            numEx3.Add(numC);
        }

        Console.WriteLine($"Numeri in lista: ");
        foreach (int i in numEx3)
        {
            Console.WriteLine($"{i}");
        }

        List<int> lstUnq = new();
        foreach (int i in numEx3)
        {
            if (!lstUnq.Contains(i))
            {
                lstUnq.Add(i);
            }
        }
        
        lstUnq.Sort();
        //numEx3 = numEx3.Distinct().ToList();
        //numEx3.Sort();

        Console.WriteLine($"Lista aggiornata: ");
        foreach (int i in lstUnq)
        {
            Console.WriteLine($"{i}");
        }
    }
}