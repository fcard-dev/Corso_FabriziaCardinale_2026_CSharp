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
        Studente s1 = new();
        Studente s2 = new();

        s1.Nome = "Luca";
        s1.Matricola = 123;
        s1.MediaVoti = 7.65;

        s2.Nome = "Sergio";
        s2.Matricola = 456;
        s2.MediaVoti = 4.53;

        s1.Descrivi();
        s2.Descrivi();
        //Console.WriteLine($"{s1.nome} ha matricola {s1.matricola} con media {s1.mediaVoti}");
        //Console.WriteLine($"{s2.nome} ha matricola {s2.matricola} con media {s2.mediaVoti}");

    }

    public static void Esercizio2()
    {
        Persona p1 = new("Maria", "Esposito", 1964);
        Persona p2 = new("Lucia", "Parisi", 1993);

        p1.Descrivi();
        p2.Descrivi();
        //Console.WriteLine($"{p1.nome} {p1.cognome} è nata nel {p1.annoNascita}");
        //Console.WriteLine($"{p2.nome} {p2.cognome} è nata nel {p2.annoNascita}");
    }

    public static void Esercizio3()
    {
        Operazioni o = new();

        Console.WriteLine($"Inserisci un numero: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Inserisci il secondo numero: ");
        int n2 = int.Parse(Console.ReadLine());

        int somma = o.Somma(n1, n2);
        int prodotto = o.Moltiplicazione(n1, n2);

        o.StampaRisultato("la somma", somma);
        o.StampaRisultato("il prodotto", prodotto);
    }
}