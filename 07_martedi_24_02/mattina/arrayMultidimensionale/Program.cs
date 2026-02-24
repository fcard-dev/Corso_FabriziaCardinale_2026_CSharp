using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {

        // ==========RANDOM==========
        /*scrivere un programma che genera un numero casuale da 1 a 10 e chiedere all'utente di indovinare*/
        Random r = new Random();
        bool ripeti = true;
        while (ripeti)
        {
            int nc = r.Next(1, 11);
            bool continuaInd = true;
            do
            {
                Console.WriteLine("Indovina il numero intero casuale che ho generato tra 1 e 10: ");
                int i = int.Parse(Console.ReadLine());
                if (i == nc)
                {
                    Console.WriteLine($"Bravo! Il numero generato è {nc}");
                    Console.WriteLine($"VUoi riprovare? S/N");
                    string risp = Console.ReadLine();
                    if (risp != "S")
                    {
                        ripeti = false;
                        continuaInd = false;
                    }
                }
                else
                {
                    Console.WriteLine($"Errato, vuoi ad indovinare di nuovo? S/N");
                    string risp1 = Console.ReadLine();
                    if (risp1 != "S")
                    {
                        continuaInd = false;
                        ripeti = false;
                        Console.WriteLine($"Il numero generato era {nc}");
                    }
                }
            } while (continuaInd);
        }

        /*simula il lancio di due dadi a 6 facce e comunica risultato e somma*/
        Random r1 = new Random();
        Random r2 = new Random();
        int d1 = r1.Next(1, 7);
        int d2 = r2.Next(1, 7);

        Console.WriteLine($"__________________________");
        Console.WriteLine($"Il primo dado ha tirato fuori {d1}");
        Console.WriteLine($"Il secondo dado ha tirato fuori {d2}");
        Console.WriteLine($"Per una somma totale di {d1 + d2}");

        /*INCOMPLETO 
        l'utente inserisce il numero di giorni da simulare. per ogni giorno viene generata una temperatura
         casuale tra minTemp e maxTemp.
         mostrare tutte le temperature, la minima, la massima e la media

        Console.WriteLine($"__________________________");
        Console.WriteLine($"Inserisci un numero di giorni: ");
        int g = int.Parse(Console.ReadLine());

        Random t = new Random();
        int temp = t.Next(-10, 41);

        for (int i = 1; i < g; i++)
        {

        }

        */

        // ==========MATRICI==========
        /*scrivi un programma che chiede all'utente le dimensioni di una matrice
        fa inserire i valori riga per riga
        calcola e stampa la somma di tutti gli elementi, delle singole righe e delle singole colonne*/
        Console.WriteLine($"__________________________");
        Console.WriteLine($"Inserisci il numero di righe di una matrice: ");
        int righe = int.Parse(Console.ReadLine());

        Console.WriteLine($"Inserisci il numero di colonne della matrice: ");
        int colonne = int.Parse(Console.ReadLine());

        int[,] matrice = new int[righe, colonne];
        int somma = 0;
        int[] sommaR = new int[righe];
        int[] sommaC = new int[colonne];

        for (int i = 0; i < righe; i++)
        {
            for (int j = 0; j < colonne; j++)
            {
                Console.WriteLine($"Inserisci singolarmente i numeri dentro la una matrice [{i},{j}]: ");
                matrice[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < righe; i++)
        {
            for (int j = 0; j < colonne; j++)
            {
                sommaR[i] += matrice[i, j];
                sommaC[j] += matrice[i, j];
                somma += matrice[i, j];
            }
        }

        Console.WriteLine($"Somma totale: {somma}");
        Console.WriteLine($"Somma righe: ");
        Console.WriteLine(string.Join(", ", sommaR));
        /*for (int i = 0; i < righe; i++)
        {
            Console.WriteLine($"{i}: {sommaR[i]}");

        }*/
        Console.WriteLine($"Somma colonne: ");
        Console.WriteLine(string.Join(", ", sommaC));
        /*for (int j = 0; j < colonne; j++)
        {
            Console.WriteLine($"{j}: {sommaC[j]}");

        }*/

        /*programma che genera 2 matrici 4x4 con numeri casuali tra 1 e 50
        stampa matrice in forma tabellare
        calcola e stampa somma di elementi di ogni riga
        confronta la somma di ogni riga tra le 2 matrici e calcola quali delle 2 matrici 
        ha più righe che vincono il confronto o se pareggiano*/
        Console.WriteLine($"__________________________");

        int[,] mx = new int[4, 4];
        int[,] mx2 = new int[4, 4];
        Random nr = new Random();
        int[] sommaRighe1 = new int[4];
        int[] sommaRighe2 = new int[4];
        int righe1 = 0;
        int righe2 = 0;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                mx[i, j] = nr.Next(1, 51);
                mx2[i, j] = nr.Next(1, 51);
                sommaRighe1[i] += mx[i, j];
                sommaRighe2[i] += mx2[i, j];
            }
        }
        Console.WriteLine($"Matrice1: ");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(mx[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Matrice2: ");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(mx2[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"Somma righe matrice 1: ");
        Console.WriteLine(string.Join(", ", sommaRighe1));
        Console.WriteLine($"Somma righe matrice 2: ");
        Console.WriteLine(string.Join(", ", sommaRighe2));
       
        for (int i = 0; i < 4; i++)
        {
            if (sommaRighe1[i] > sommaRighe2[i])
            {
                righe1++;
            }
            else if (sommaRighe1[i] < sommaRighe2[i])
            {
                righe2++;
            }
        }

        if (righe1 > righe2)
        {
            Console.WriteLine($"Matrice 1 ha più righe.");
        }
        else if (righe1 < righe2)
        {
            Console.WriteLine($"Matrice 2 ha più righe.");
        }
        else
        {
            Console.WriteLine($"Matrice 1 e 2 hanno le stesse righe");
        }

        /*programma che genera matrice qudrata 5x5 con numeri casuali tra 1 e 20
        stampa matrice
        calcola e stampa somma diagonale principale e secondaria
        indica quale somma è maggiore*/

        Console.WriteLine($"__________________________");

        int[,] matriceQ = new int[5, 5];
        Random nr2 = new Random();
        int sommaDiagonali1 = 0;
        int sommaDiagonali2 = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matriceQ[i, j] = nr2.Next(1, 21);
                if (i == j)
                {
                    sommaDiagonali1 += matriceQ[i, j];
                }
                else if (i + j == 4)
                {
                    sommaDiagonali2 += matriceQ[i, j];
                }

            }
        }
        Console.WriteLine($"MatriceQ: ");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matriceQ[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Somma diagonale principale: {sommaDiagonali1}");
        Console.WriteLine($"Somma diagonale secondaria: {sommaDiagonali2}");

        if (sommaDiagonali1 > sommaDiagonali2)
        {
            Console.WriteLine($"La somma della diagonale principale è maggiore della secondaria");
        }
        else if (sommaDiagonali1 < sommaDiagonali2)
        {
            Console.WriteLine($"La somma della diagonale secondaria è maggiore della principale");
        }
        else
        {
            Console.WriteLine("La somma delle diagonali è uguale");
        }
    }
}