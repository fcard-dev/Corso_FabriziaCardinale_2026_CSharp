using System;

class Program
{
    static int seq = 0;
    static void Main(string[] args)
    {
        /*scrivi un metodo raddoppia che riceve un numero inter per ref e lo raddoppia.
        mostra il valore prima e dopo*/
        int numero1 = 3;
        Console.WriteLine($"Numero iniziale {numero1}");
        Raddoppia(ref numero1);
        Console.WriteLine($"Numero finale {numero1}");
        Console.WriteLine("_______________________________________");


        /*scrivi un metodo aggiustadata che riceve 3 variabili giorno mese annotramite ref.
        se il giorno supera 30 amenta il mese, se il mese supera 12 aumenta l'anno*/
        int giorno = 32;
        int mese = 12;
        int anno = 1992;
        AggiustaData(ref giorno, ref mese, ref anno);
        Console.WriteLine($"Giorno {giorno}; Mese {mese}; Anno {anno}");
        Console.WriteLine("_______________________________________");

        /*scrivi un metodo dividi che accetta due numeri interi e restituisce il quoziente 
        e il resto tramite out*/
        int n1 = 49;
        int n2 = 8;
        int quoziente;
        int resto;
        Dividi(n1, n2, out quoziente, out resto);
        Console.WriteLine($"Il quoziente di {n1}/{n2} è {quoziente}; il resto di {n1}%{n2} è {resto}");
        Console.WriteLine("_______________________________________");

        /*scrivi un metodo analizzaparola che riceve una stringa e restituisce tramite out
        numero vocali, numero consonanti, numero spazi*/
        string frase = "Jiraiya non dovevi andartene così!";
        int vocali;
        int spazi;
        int consonanti;
        AnalizzaParola(frase, out vocali, out spazi, out consonanti);
        Console.WriteLine($"Per la frase: {frase}, il numero di vocali è {vocali}, il numero di spazi è {spazi} e il numero di consonanti è {consonanti}");
        Console.WriteLine("_______________________________________");

        /*scrivi un metodo aggiornapunteggio che riceve il punteggio corrente per ref
        riceve un bonus per valore
        il punteggio totale per ref calcolato ogni volta
        restituisce tramite out il punteggio medio su 3 turni 
        il metodo deve essere chiamato 3 volte in sequenza, ogni volta inserendo un punteggio diverso
        alla 3 chiamata, l'out deve contenere la media*/
        double punteggioCorrente = 7;
        double mediaP;
        AggiornaPunteggio(ref punteggioCorrente, out mediaP, 1.0);
        Console.WriteLine($"Il punteggio corrente è {punteggioCorrente}");
        AggiornaPunteggio(ref punteggioCorrente, out mediaP, 3.0);
        Console.WriteLine($"Il punteggio corrente è {punteggioCorrente}");
        AggiornaPunteggio(ref punteggioCorrente, out mediaP, 2.5);
        Console.WriteLine($"Il punteggio corrente è {punteggioCorrente} con media {mediaP}");
        Console.WriteLine("_______________________________________");

        /*scrivi un metodo elaborastudente che riceve voto1 e voto 2 per ref
        applica un bonus passato per valore ad ogni voto (non oltre 10)
        tramite out deve restituire la media dei due voti e avere un return con un valore bool promosso true se >= 6 o false
        nel main si deve controllare se uno studente è passato o no*/
        double voto1 = 7.4d;
        double voto2 = 5.8d;
        double media;
        bool verifica = ElaboraStudente(ref voto1, ref voto2, out media, 1.0);
        if (verifica == true)
        {
            Console.WriteLine($"Promosso con una media di {media}");
        }
        else
        {
            Console.WriteLine($"Bocciato con una media di {media}");
        }
        Console.WriteLine("_______________________________________");

        /*scrivi un metodo analizzaseriedinumeri che prende come parametro 3 numeri(valore)
        come out il minimo e il massimo e come return la media*/
        int min;
        int max;
        double mediaSerie = AnalizzaNumeri(-4748, 9345, 22, out min, out max);
        Console.WriteLine($"Numero minimo {min}, numero massimo {max}, media totale {mediaSerie}");
        Console.WriteLine("_______________________________________");

    }

    public static void Raddoppia(ref int n)
    {
        n = n * 2;
    }

    public static void AggiustaData(ref int g, ref int m, ref int a)
    {
        if (g > 30)
        {
            g = 1;
            m++;
        }

        if (m > 12)
        {
            m = 1;
            a++;
        }
    }

    public static void Dividi(int a, int b, out int quoziente, out int resto)
    {
        quoziente = a / b;
        resto = a % b;
    }

    public static void AnalizzaParola(string f, out int vocali, out int spazi, out int consonanti)
    {
        vocali = 0;
        spazi = 0;
        consonanti = 0;

        string v = "aeiouAEIOU";

        foreach (char c in f)
        {
            if (char.IsWhiteSpace(c))
            {
                spazi++;
            }
            else if (v.Contains(c))
            {
                vocali++;
            }
            else if (char.IsLetter(c))
            {
                consonanti++;
            }
        }
    }

    public static bool ElaboraStudente(ref double v1, ref double v2, out double media, double bonus)
    {

        if (v1 > 10)
        {
            v1 = 10;
        }
        else
        {
            v1 = v1 + bonus;
        }

        if (v2 > 10)
        {
            v2 = 10;
        }
        else
        {
            v2 = v2 + bonus;
        }

        media = (v1 + v2) / 2;

        if (media >= 6)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void AggiornaPunteggio(ref double pC, out double mP, double bonus)
    {
        seq++;
        pC += bonus;

        if (seq == 3)
        {
            mP = pC / 3;
        }
        else
        {
            mP = 0;
        }
    }

    public static double AnalizzaNumeri(int nm1, int nm2, int nm3, out int min, out int max)
    {
        if (nm1 < nm2 && nm1 < nm3)
        {
            min = nm1;
        }
        else if (nm2 < nm1 && nm2 < nm3)
        {
            min = nm2;
        }
        else
        {
            min = nm3;
        }

        if (nm1 > nm2 && nm1 > nm3)
        {
            max = nm1;
        }
        else if (nm2 > nm1 && nm2 > nm3)
        {
            max = nm2;
        }
        else
        {
            max = nm3;
        }

        double mediaS = (nm1 + nm2 + nm3) / 3.0;
        return mediaS;
    }
}

