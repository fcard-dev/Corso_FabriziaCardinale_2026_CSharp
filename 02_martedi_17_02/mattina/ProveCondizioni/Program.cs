using System;

class Program
{
    static void Main(string[] args)

    {
        /*int a = 15;
        int b = 10;
        if (a > b)
        {
            Console.WriteLine($"{a} è maggiore di {b}");
        }*/

        /*scrivere un programma che chieda all'utente la sua età e stampi a schermo se è maggiorenne o minorenne 
        Console.Write("dimmi la tua età ");

        const int maggiorenne = 18;

        string eta = Console.ReadLine();
        int intEta = int.Parse(eta);
        //
        if (intEta >= maggiorenne)
        {
            Console.WriteLine("sei maggiorenne ");
        }
        else
        {
            Console.WriteLine("sei minorenne");
        } */

        /*scrivere un programma che richiede all'utente il prezzo di un prodotto e applica uno sconto del 10% se il prezzo supera 100 euro. Stampare prezzo finale
        Console.Write("dimmi il prezzo di quel prodotto ");
        string prezzo = Console.ReadLine();
        double doublePrezzo = double.Parse(prezzo);

        if (doublePrezzo > 100)
        {
            double sconto = 0.10d;
            double prezzoScontato = doublePrezzo - (doublePrezzo * sconto);
            Console.WriteLine($"il prezzo iniziale era {prezzo} euro, con il 10% di sconto ora è {prezzoScontato} euro");
        }
        else
        {
            Console.WriteLine($"il prezzo è {prezzo} euro");
        } */

        /*scrivere un programma che chiede tre numeri interi all'utente. Se la media aritmetica dei tre numeri è maggiore o uguale a 60, stampare 
        "hai superato la prova" altrimenti stampare "prova fallita". stampare anche il valore esatto della media
        Console.Write("dimmi un numero ");
        string n1 = Console.ReadLine();
        int intN1 = int.Parse(n1);
        Console.Write("dimmi un secondo numero ");
        string n2 = Console.ReadLine();
        int intN2 = int.Parse(n2);
        Console.Write("dimmi un terzo numero ");
        string n3 = Console.ReadLine();
        int intN3 = int.Parse(n3);

        double media = (intN1 + intN2 + intN3) / 3.0;

        if (media >= 60)
        {
            Console.WriteLine($"Hai superato la prova con {media}");
        }
        else if (media <= 50 && media >= 40)
        {
            Console.WriteLine($"Prova fallita con {media}");
        }
        else
        {
            Console.WriteLine($"Prova fallita MISERAMENTE con {media}");
        } */


        /*int a = 10;
        int b = 15;
        if (a > b)
        {
        Console.WriteLine($"{a} è maggiore di {b}");
        } else 
        {
        Console.WriteLine($"{a} è minore di {b}");
        }*/


        /*scrivi un programma che richiede all'utente di inserire un numero intero e determini se pari o dispari
        Console.Write("dammi un numero: ");
        string num = Console.ReadLine();
        int intNum = int.Parse(num);

        if (intNum % 2 == 0)
        {
            Console.WriteLine($"il numero {intNum} è pari!");
        }
        else
        {
            Console.WriteLine($"il numero {intNum} è dispari!");
        } */
        /*crea un semplice programma che richieda all'utente di inserire una password numerica. se la password
        corrisponde a una costante predefinita, stampa accesso consentito altrimenti stampa accesso negato
        const int pswNum = 12345;

        Console.Write("inserisci una password numerica: ");
        string psw = Console.ReadLine();
        int intPSW = int.Parse(psw);

        if (intPSW == pswNum)
        {
            Console.WriteLine("Accesso consentito!");
        }
        else
        {
            Console.WriteLine("Accesso negato!");
        } */

        /*realizza una calcolatrice semplificata che chieda due double e un operatore + o -. il programma deve
        effettuare l'operazione richiesta e stampare il risultato. se l'utente inserisce un operatore diverso,
        stampare operatore non valido
        Console.Write("dammi un numero decimale: ");
        string n1 = Console.ReadLine();
        Console.Write("dammi un altro numero decimale: ");
        string n2 = Console.ReadLine();
        Console.Write("Che operatore vuoi usare tra + e -? ");
        string operatore = Console.ReadLine();

        double doubleN1 = double.Parse(n1);
        double doubleN2 = double.Parse(n2);

        if (operatore == "+")
        {
            Console.WriteLine($"Il risultato tra {doubleN1} + {doubleN2} = " + (doubleN1 + doubleN2));
        }
        else if (operatore == "-")
        {
            Console.WriteLine($"Il risultato tra {doubleN1} - {doubleN2} = " + (doubleN1 - doubleN2));
        }
        else
        {
            Console.WriteLine($"Operatore {operatore} non valido");
        } */
        /*int eta = 15;
        if (eta >= 18)
               {
                  Console.WriteLine("Maggiorenne"); 
               } else if (eta >= 13 )
               {
                   Console.WriteLine("Adolescente");
               }else
               {
                   Console.WriteLine("Minorenne");
               }
       */

        /*scrivi un programma che chieda all'utente un voto da 1 a 10 e stampi una valutatione
        Console.Write("dammi un voto da 1 a 10: ");
        string voto = Console.ReadLine();
        int intVoto = int.Parse(voto);

        if (intVoto >= 1 && intVoto <= 4)
        {
            Console.WriteLine("Insufficiente");
        }
        else if (intVoto >= 5 && intVoto <= 6)
        {
            Console.WriteLine("Sufficiente");
        }
        else if (intVoto >= 7 && intVoto <= 8)
        {
            Console.WriteLine("Buono");
        }
        else if (intVoto >= 9 && intVoto <= 10)
        {
            Console.WriteLine("Ottimo");
        }*/

        /*programma che calcola bmi
        Console.Write("dimmi l'altezza in metri: ");
        string h = Console.ReadLine();
        Console.Write("dimmi il peso in kg: ");
        string p = Console.ReadLine();

        double doubleH = double.Parse(h);
        double doubleP = double.Parse(p);

        double bmi = doubleP / (doubleH * doubleH);

        if (bmi < 18.5)
        {
            Console.WriteLine("Sottopeso");
        }
        else if (bmi >= 18.5 && bmi < 25)
        {
            Console.WriteLine("Normopeso");
        }
        else if (bmi >= 25 && bmi <= 30)
        {
            Console.WriteLine("Sovrappeso");
        }
        else if (bmi >= 30)
        {
            Console.WriteLine("Obeso");
        }*/

        /*scrivi un proramma che converta la temperatura inserita in celsius a un'altra scala a scelta tra
        Fahreneit, Kelvin, Rankine. Stampa il risultato 
        Console.Write("dimmi i gradi in Celsius: ");
        string gradiC = Console.ReadLine();
        Console.Write("come li vuoi convertire? Scegli tra F-Fahreneit, K-Kelvin, R-Rankine: ");
        string gradiConv = Console.ReadLine();

        double doubleGradiC = double.Parse(gradiC);

        if (gradiConv == "F")
        {
            Console.WriteLine((doubleGradiC * 0.8) + 32);
        }
        else if (gradiConv == "K")
        {
            Console.WriteLine(doubleGradiC + 273.15);
        }
        else if (gradiConv == "R")
        {
            Console.WriteLine((doubleGradiC * 1.8) + 491.67);
        } */
        /*
                string giorno = "lunedi";
                switch (giorno)
                {
                    case "lunedi":
                        Console.WriteLine("inizio settimana");
                        break;
                    case "venerdi":
                        Console.WriteLine("fine settimana");
                        break;
                    default:
                        Console.WriteLine("altro giorno");
                        break;
                }
        */
        /*programma che chiede di inserire un numero da 1 a 7 e restituisca il giorno corrispondente della settimana
        Console.Write("scegli un numero da 1 a 7 che corrispondono ai giorni della settimana: ");
        string g = Console.ReadLine();

        switch (g)
        {
            case "1":
                Console.WriteLine("lunedi");
                break;
            case "2":
                Console.WriteLine("martedi");
                break;
            case "3":
                Console.WriteLine("mercoledi");
                break;
            case "4":
                Console.WriteLine("giovedi");
                break;
            case "5":
                Console.WriteLine("venerdi");
                break;
            case "6":
                Console.WriteLine("sabato");
                break;
            case "7":
                Console.WriteLine("domenica");
                break;
            default:
                Console.WriteLine("Non esistono altri giorni.");
                break;
        }
*/
        /*scrivi un programma che chieda all'utente quale figura geometrica vuole calcolare tra quadrato, cerchio e triangolo
        quindi chiede le misure necessarie e calcola l'area corrispondente

        Console.Write("Di che figura vuoi misurare l'area? C-Cerchio, Q-quadrato o T-triangolo? ");
        string f = Console.ReadLine();

        switch (f)
        {
            case "C":
                Console.Write("Inserisci il raggio: ");
                string rc = Console.ReadLine();
                double dRC = double.Parse(rc);
                Console.WriteLine("l'area del cerchio è: " + (dRC * dRC));
                break;
            case "Q":
                Console.Write("Inserisci il lato: ");
                string lq = Console.ReadLine();
                double dLQ = double.Parse(lq);
                Console.WriteLine("l'area del quadrato è: " + (dLQ * dLQ));
                break;
            case "T":
                Console.Write("Inserisci la base: ");
                string bT = Console.ReadLine();
                double dBT = double.Parse(bT);
                Console.Write("Inserisci l'altezza: ");
                string hT = Console.ReadLine();
                double dHT = double.Parse(hT);
                Console.WriteLine("l'area del triangolo è: " + (dBT * dHT) / 2);
                break;
            default:
                Console.WriteLine("Selezione errata.");
                break;
        }*/
        /*extra
        Console.Write("Scegli BG-buongiorno o BN-buonanotte: ");
        string s = Console.ReadLine();

        switch (s)
        {
            case "BG":
                Console.Write("Ora scegli P-pranzo o C-colazione: ");
                string s2 = Console.ReadLine();

                if (s2 == "P")
                {
                    Console.WriteLine("Buon pranzo!");
                }
                else if (s2 == "C")
                {
                    Console.WriteLine("Buona colazione!");
                }
                break;
            case "BN":
                Console.WriteLine("Buonanotte!");
                break;
            default:
                Console.WriteLine("scelta errata");
                break;
        }
*/


    }
}


