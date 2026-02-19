using System;

class Program
{
    static void Main(string[] args)
    {
        /*scrivi un metodo StampaSaluto che riceve come parametro una stringa 
           con il nome dell'utente e stamoa un saluto personalizzato*/

        Console.WriteLine("Come ti chiami? ");
        string nome = Console.ReadLine();
        StampaSaluto(nome);

        /*crea un metodo VerificaPari che riceve un numero intero e stampa a video 
        se questo numero è pari o dispari*/

        Console.WriteLine("Dimmi un numero: ");
        int n = int.Parse(Console.ReadLine());
        VerificaPari(n);

        /*scrivi un metodo CalcolaPotenza che riceve due parametri interi (baseNum ed esponente)
        e restituisce il risultato della potenza(baseNum^esponente). stampa il risultato*/

        Console.WriteLine("Dammi un numero:");
        int baseNum = int.Parse(Console.ReadLine());
        Console.WriteLine("A cosa vuoi elevarlo? ");
        int esponente = int.Parse(Console.ReadLine());
        int tot = CalcolaPotenza(baseNum, esponente);
        Console.WriteLine($"Il risultato di {baseNum} elevato a {esponente} è {tot} ");

    }
    public static void StampaSaluto(string nome)
    {
        Console.WriteLine($"Ciao {nome}!");
    }

    public static void VerificaPari(int n)
    {
        if (n % 2 == 0)
        {
            Console.WriteLine($"Il numero {n} è pari!");
        }
        else
        {
            Console.WriteLine($"Il numero {n} è dispari.");
        }
    }

    public static int CalcolaPotenza(int baseNum, int esponente)
    {
        int tot = 1;
        for (int i = 0; i < esponente; i++)
        {
            tot *= baseNum;
        }
        return tot;
    }
}

