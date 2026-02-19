
using System;

class Program
{
    static void Main(string[] args)

    {
        bool continua = true;
         while (continua)
         {
             Console.WriteLine("in esecuzione");
             continua = bool.Parse(Console.ReadLine());
         }

         int continua2 = 0;
         while (continua2 < 10)
         {
             Console.WriteLine("Ciclo in esecuzione");
             continua2 += 1;
             Console.WriteLine(continua2);
         } 

        /*scrivi un programma che continui a chiedere all'utente di inserire numeri interi postivi.
        il programma termina quando l'utente inserisce un numero negativo e stampa la somma totale dei 
        numeri inseriti senza contare il numero negativo*/
        int num = 1;
        int somma = 0;
        while (num > 0)
        {
            Console.Write("inserisci un numero: ");
            string n1 = Console.ReadLine();
            num = int.Parse(n1);

            if (num > 0)
            {
                somma += num;
            }
        }
        Console.WriteLine("La somma totale è " + somma); 


        /*scrivi un programma che definisca un numero segreto come costante. l'utente dovrà indovinare questo 
        numero continuando a fare tentativi finchè non lo indovina correttamente. il programma
        risponde ogni volta indicando se il numero inserito è maggiore o minore rispetto al n.segr.*/
        const int NUM_SEGR = 20;
        int prova = 0;

        while (prova !=  NUM_SEGR)
        {
            Console.Write("indovina il numero: ");
            prova = int.Parse(Console.ReadLine());

            if (prova >  NUM_SEGR)
            {
                Console.WriteLine("numero troppo alto");
            }
            else if (prova <  NUM_SEGR)
            {
                Console.WriteLine("numero troppo basso");
            }
        }
        Console.WriteLine("Numero corretto"); 

        /*scrivere un programma che simuli il funzionamento di un semplice sportello bancomat
        utilizzando il ciclo while per gestire un menu di operazioni finchè l'utente non decide di uscire.
        requisiti:
        -il programma deve mostrare un menu con le seguenti opzioni: visualizza saldo, deposita denaro,
        preleva denaro, esci
        -il saldo iniziale è 0
        -l'utente può ripetere le operazioni quante volte vuole, finchè non sceglie esci
        -se si tenta di prelevare più saldo del disponibile serve messaggio di errore*/
        bool uscita = true;
        float saldo = 0;

        while (uscita)
        {
            Console.WriteLine("Seleziona l'opzione: ");
            Console.WriteLine("1-Visualizza saldo; ");
            Console.WriteLine("2-Deposita denaro; ");
            Console.WriteLine("3-Preleva denaro; ");
            Console.WriteLine("4-Esci. ");
            string opzione = Console.ReadLine();

            if (opzione == "1")
            {
                Console.WriteLine($"Saldo disponibile: {saldo}.");
            }
            else if (opzione == "2")
            {
                Console.Write("Indica quanto denaro vuoi depositare: ");
                string deposito = Console.ReadLine();
                float floatDeposito = float.Parse(deposito);
                saldo += floatDeposito;
                Console.WriteLine($"Hai depositato {floatDeposito}.");

            }
            else if (opzione == "3")
            {
                Console.Write("Indica quanto denaro vuoi prelevare: ");
                string prelievo = Console.ReadLine();
                float floatPrelievo = float.Parse(prelievo);
               
                if (floatPrelievo > saldo)
                {
                    Console.WriteLine("Saldo disponibile insufficiente.");
                }
                else
                {
                    saldo -= floatPrelievo;
                    Console.WriteLine($"Hai prelevato {floatPrelievo}.");
                }
            }
            else if (opzione == "4")
            {
                Console.WriteLine("Arrivederci.");
                uscita = false;
            }
            else
            {
                Console.WriteLine("Scelta non valida!");
            }
        }
        

        /*bool continua = true;
        do
        {
            Console.WriteLine("Ciclo in esecuzione");
            continua = VerificaCondizione();
        }
        while(continua);*/

        /*scrivi un programma che chieda una password numerica all'utente. 
        ha a disposizione fino a 3 tentativi. il programma termina se la password è corretta o se finiscono
        i tentativi disponibili */
        const int PSW = 12345;
        int tentativi = 0;
        int pswIns = 0;

        do
        {
            Console.Write("Inserisci password numerica: ");
            string pswN = Console.ReadLine();
            pswIns = int.Parse(pswN);
            tentativi += 1;

            if (pswIns == PSW)
            {
                Console.WriteLine("Password corretta.");
            }
            else
            {
                Console.WriteLine($"Password errata, tentativi effettuati {tentativi}");
            }
        }
        while (tentativi < 3 && pswIns != PSW);

        /*realizza un programma che permette all'utente di inserire numeri interi finché non inserisce lo zero. 
        al termine stampa la somma e quanti numeri sono stati inseriti.*/
        int n;
        int somma = 0;
        int numIns = 0;
        do
        {
            Console.Write("Inserisci numeri interi: ");
            string nIns = Console.ReadLine();
            n = int.Parse(nIns);

            if (n != 0)
            {
                somma += n;
                numIns += 1;
            }
        }
        while (n != 0);
        Console.WriteLine($"Numeri inseriti: {numIns}");
        Console.WriteLine($"Somma totale: {somma}"); 

        /*crea una calcolatrice che permette all'utente di effettuare più operazioni matematiche.
        dopo ogni operazione, il programma chiede se vuole eseguire un'altra operazione o terminare
        string scelta;*/
        do
        {
            Console.Write("inserisci un numero: ");
            string n1 = Console.ReadLine();
            Console.Write("inserisci un altro numero: ");
            string n2 = Console.ReadLine();
            Console.Write("Che operatore vuoi usare tra +, -, / e *? ");
            string operazione = Console.ReadLine();

            double doubleN1 = double.Parse(n1);
            double doubleN2 = double.Parse(n2);

            if (operazione == "+")
            {
                Console.WriteLine($"Il risultato tra {doubleN1} + {doubleN2} = " + (doubleN1 + doubleN2));
            }
            else if (operazione == "/")
            {
                Console.WriteLine($"Il risultato tra {doubleN1} / {doubleN2} = " + (doubleN1 / doubleN2));
            }
            else if (operazione == "*")
            {
                Console.WriteLine($"Il risultato tra {doubleN1} * {doubleN2} = " + (doubleN1 * doubleN2));
            }
            else if (operazione == "-")
            {
                Console.WriteLine($"Il risultato tra {doubleN1} - {doubleN2} = " + (doubleN1 - doubleN2));
            }

            Console.Write("Vuoi fare un'altra operazione?\n S-Si;\n N-No;\n ");
            scelta = Console.ReadLine();
        }
        while (scelta == "S"); 

        /* for (int i = 0; i < 10; i++)
         {
             Console.WriteLine(i);
         } */

        /*scrivi un programma che chieda all'utente un numero intero e 
        stampi la sua tabellina (moltiplicazioni da 1 a 10)*/
        Console.Write("Dimmi un numero intero: ");
        string n = Console.ReadLine();
        int intN = int.Parse(n);

        for (int i = 0; i <= 10; i++)
        {
            int risultato = intN * i;
            Console.WriteLine($"{intN} x {i} = {risultato} ");
        }

        /*scrivi un programma che chieda all'utente quanti numeri vuole inserire. il 
        programma acquisisce i numeri e alla fine calcola e stampa la loro media*/
        Console.Write("Quanti numeri vuoi inserire? ");
        string scelta = Console.ReadLine();
        int intScelta = int.Parse(scelta);
        double somma = 0;
        for (int i = 0; i < intScelta; i++)
        {
            Console.Write("Inserisci numero: ");
            string num = Console.ReadLine();
            double dNum = double.Parse(num);
            somma += dNum;
        }

        double tot = somma / intScelta;
        Console.WriteLine($"La media tra i numeri scelti è {tot}");

        /* INCOMPLETO 
        scrivi un programma che chieda all'utente un numero intero positivo e calcoli il suo fattoriale(n!).
        assicurati che l'utente inserisca un numero positivo; altrimenti messaggio di errore
        Console.Write("Inserisci un numero intero positivo: ");
        string np = Console.ReadLine();
        int intNP = int.Parse(np);

        if (intNP >= 0)
        {
            for (int i = 0; i <= intNP ; i++)
            {
                int calcolo = 
            }
            Console.WriteLine($"Il fattoriale è {calcolo}");
        }
        else
        {
            Console.WriteLine("Numero non valido.");
        } 
        */
    }
}

