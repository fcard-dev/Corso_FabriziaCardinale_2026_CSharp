using System;

class Program
{
    static void Main(string[] args)
    {
        /* -somma di due numeri: dichiarare due variabili di tipo int, assegnare loro dei valori, sommarle e stampare il risultato
         int numeroA = 78;
         int numeroB = 24;
         Console.WriteLine("la somma di numeroA e numeroB è " + numeroA + numeroB);

         -calcolo di un prezzo scontato: crea una variabile double per il prezzo originale e applica uno sconto del 20%, stampando il prezzo finale
         double prezzo = 20.6d;
         double sconto = 0.20d;
         double prezzoScontato = prezzo - (prezzo * sconto);
         Console.WriteLine("il prezzo scontato è " + prezzoScontato);

         -controllo di un numero positivo: dichiara una variabile float e usa un'espressione di comparazione per verificare se il numero è positivo. visualizza il risultato booleano 
         float numeroDecimale = 4.9f;
         bool isPositive = numeroDecimale > 0;
         Console.WriteLine("la variabile numeroDecimale è positiva? " + isPositive);

         float numeroDecimale2 = -8.4f;
         bool isPositive2 = numeroDecimale2 > 0;
         Console.WriteLine("la variabile numeroDecimale2 è positiva? " + isPositive2); */

        /*somma tra intero e float 
        chiedi all'utente un numero intero e un numero con la virgola esegui la somma tra due numeri e stampa
         Console.Write("inserisci un numero intero ");
        string n1 = Console.ReadLine();
        Console.Write("inserisci un numero decimale ");
        string n2 = Console.ReadLine();
        
        int intN1 = int.Parse(n1);
        float floatN2 = float.Parse(n2);
        Console.WriteLine("la somma tra i numeri inseriti è: " + (intN1 + floatN2));*/

        /*età e altezza con casting, chiedi l'età all'utente e la sua altezza, esegui la somma tra età e altezza in metri (float) convertita in int
        Console.Write("inserisci la tua età ");
        string eta = Console.ReadLine();
        Console.Write("inserisci la tua altezza in metri ");
        string altezza = Console.ReadLine();

        int intEta = int.Parse(eta);
        float floatAltezza = float.Parse(altezza);
        
        int risultato = (int)(intEta + floatAltezza);
        Console.WriteLine("la somma di età e altezza inserita è: " + risultato); */

        /*usare tutti e tre gli operatori logici in un unico print con dati da input*/
        Console.Write("dimmi la tua eta ");
        string eta2 = Console.ReadLine();
        Console.Write("dimmi l'età di un tuo parente ");
        string eta3 = Console.ReadLine();

        int intEta2 = int.Parse(eta2);
        int intEta3 = int.Parse(eta3);

        Console.WriteLine((intEta2 <= 10) || (intEta2 >= 15) && (intEta3 >= 20) || (!(intEta3 <= 10)));
        

    }

}


