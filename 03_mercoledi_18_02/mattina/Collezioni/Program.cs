using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        /*  //creiamo un array di 5 elementi per contenere i voti
          int[] voti = new int[5];

          //inserimento dei voti da tastiera
          for (int i = 0; i < voti.Length; i++)
          {
              Console.Write($"Inserisci il voto {i + 1}:");
              voti[i] = int.Parse(Console.ReadLine());
          }
          //calcolo della media
          int somma = 0;
          for (int i = 0; i < voti.Length; i++)
          {
              somma += voti[i];
          }
          float media = (float)somma / voti.Length;
          Console.WriteLine($"La media dei voti è: {media}");*/


        /*  int[] numeri = new int[4];
          numeri[0] = 2;
          numeri[1] = 4;
          numeri[2] = 6;
          numeri[3] = 8;
          Console.WriteLine("Numeri dell'array: ");
          foreach(int n in numeri)
          {
              Console.WriteLine(n);
          } */

        /*vai a creare un sistema che ti chiede di scegliere tra stringe o interi
        dopo deve selezionare quanto vuole lungo l'array da creare inserendolo a mano
        per poi far inserire X vlte una stringa o un int in base alla selezione.
        deve stampare e poi chiedere se si vuole ripetere*/
        string scelta = "";
        bool b = true;
        while (b)
        {
            Console.WriteLine("Scegli: ");
            Console.WriteLine("S-Stringa ");
            Console.WriteLine("I-Interi ");
            scelta = Console.ReadLine();

            Console.WriteLine($"Hai scelto {scelta}! Quando vuoi che sia lungo l'array? ");
            int lunghezza = int.Parse(Console.ReadLine());

            if (scelta == "S")
            {
                string[] arrayS = new string[lunghezza];
                for (int i = 0; i < arrayS.Length; i++)
                {
                    Console.WriteLine("Inserisci valore: ");
                    arrayS[i] = Console.ReadLine();
                }
                Console.WriteLine("Elementi inseriti: ");
                foreach (string s in arrayS)
                {
                    Console.WriteLine(s);
                }
            }
            else if (scelta == "I")
            {
                int[] arrayI = new int[lunghezza];
                for (int i = 0; i < arrayI.Length; i++)
                {
                    Console.WriteLine("Inserisci valore: ");
                    arrayI[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Elementi inseriti: ");
                foreach (int n in arrayI)
                {
                    Console.WriteLine(n);
                }
            }
            else
            {
                Console.WriteLine("Selezione errata.");
            }

            Console.WriteLine("Vuoi ripetere? S/N");
            string risp = Console.ReadLine();
            if (risp != "S")
            {
                b = false;
            }
        }

        /*scrivi un programma che chiede all'utente di inserire una frase e utilizza 
        il foreach per contare quanti caratteri sono cifre (0-9)*/
        int conto = 0;

        Console.WriteLine("Inserisci una frase: ");
        string frase = Console.ReadLine();
        foreach (char c in frase)
        {
            if (char.IsDigit(c))
            {
                conto++;
            }
        }
        Console.WriteLine($"Il totale delle cifre è {conto}");
        /*scrivi un programma che riceve una frase dall'utente e usa foreach per costruire 
        e stampare una nuova stringa che contiene solo i caratteri senza spazi*/
        Console.WriteLine("Inserisci una frase: ");
        string f = Console.ReadLine();
        string f2 = f.Replace(" ", "");
        Console.WriteLine($"La nuova stringa è: {f2}");
        //altrimenti
        Console.WriteLine("Inserisci una frase: ");
        string fm2 = Console.ReadLine();
        string nuova = "";

        foreach (char cr in fm2)
        {
            if (!char.IsWhiteSpace(cr))
            {
                nuova += cr;
            }
        }
        Console.WriteLine($"La nuova stringa è: {nuova}");

        /*scrivi un metodo che riceve una stringa e restituisce il numero di vocali contenute*/
        int tot = 0;
        Console.WriteLine("Inserisci una stringa: ");
        string st = Console.ReadLine();

        foreach (char cr2 in st)
        {
            if ("aeiou".Contains(char.ToLower(cr2)))
            {
                tot++;
            }
        }
        Console.WriteLine($"Il totale di vocali è: {tot}");

        /*scrivi un metodo che verifica se una password è valida:
        -una maiuscola
        -una cifra
        -8 caratteri
        -no spazio inizio o fine
        */

        int maiuscola = 0;
        int cifre = 0;

        Console.WriteLine("Inserisci password: ");
        string password = Console.ReadLine();

        if (password.Length >= 8 || !password.StartsWith(" ") || !password.EndsWith(" "))
        {
            foreach (char psw in password)
            {
                if (char.IsDigit(psw))
                {
                    cifre++;
                }

                if (char.IsUpper(psw))
                {
                    maiuscola++;
                }
            }

            if (cifre > 0 && maiuscola > 0)
            {
                Console.WriteLine("Password valida. ");
            }
            else
            {
                Console.WriteLine("Password non valida. ");
            }
        }
        else
        {
            Console.WriteLine("Password non valida. ");
        }

        /*metodo che riceve stringa e restituisce
        numero parole
        numero caratteri alfabetici
        numero spazi
        numero segni puntegg*/

        int alfab = 0;
        int spazi = 0;
        int puntegg = 0;

        Console.WriteLine("inserisci una frase: ");
        string stringa = Console.ReadLine();
        string[] parole = stringa.Split(" ");
        int parola = parole.Length;

        foreach (char x in stringa)
        {
            if (char.IsLetter(x))
            {
                alfab++;
            }

            if (char.IsWhiteSpace(x))
            {
                spazi++;
            }

            if (char.IsPunctuation(x))
            {
                puntegg++;
            }
        }
        Console.WriteLine($"Il totale delle parole è: {parola} ");
        Console.WriteLine($"Il totale delle lettere è: {alfab} ");
        Console.WriteLine($"Il totale degli spazi è: {spazi} ");
        Console.WriteLine($"Il totale della punteggiatura è: {puntegg} ");
    }
}

