using System;

class Program
{
    const float PI_NUMBER = 3.1415f;
    public static readonly string NomeLui = "Franco";

    static void Main(string[] args)
    {
        /* int contatore; //dichiarazione
        contatore = 0; //assegnazione
        int somma = 10; //dichiarazione + inizializzazione
        var nome = "Ada";
        var eta = " anni"; //tipo dedotto dal compilatore ("inferenza") 

        int numero = 10; //numero intero
        float decimaleFloat = 3.14f; //numero a virgola mobile
                                     //double decimaleDouble = 3.14f;  //numero a virgola mobile
        char lettera = 'A'; //singolo carattere
        bool condizione = true; //bit 0 (false) o 1 (true)
        string saluto = "ciao a tutti!"; //molteplici caratteri

        int intero = 42;
        float numeroLungo = intero;

        float pi = 3.14f;
        int circaPi = (int)pi;

        //questa riga stampa a video
        Console.WriteLine("Hello, World!");

        Console.WriteLine(contatore);
        Console.WriteLine(somma);
        Console.WriteLine(nome + " ha " + somma + eta);

        Console.WriteLine("numero: " + numero);
        Console.WriteLine("decimale: " + decimaleFloat);
        Console.WriteLine("lettera: " + lettera);
        Console.WriteLine("condizione: " + condizione);
        Console.WriteLine("saluto: " + saluto);

        Console.WriteLine("Ciao mi chiamo " + NomeLui);

        Console.WriteLine(numeroLungo + 0.6);
        Console.WriteLine(circaPi);

        Console.Write("come ti chiami?");
        string nomeLei = Console.ReadLine();
        Console.Write($"Ciao {nomeLei}!");

        Console.Write("Dammi un numero? ");
        string n1 = Console.ReadLine();
        Console.Write("Dammi un altro numero? ");
        string n2 = Console.ReadLine(); 

        int numero1 = int.Parse(n1);
        int numero2 = int.Parse(n2);
        Console.WriteLine($"Somma {numero1 + numero2}!");*/
int a = 10;
int b = 15;
        Console.WriteLine("Operatori aritmetici:");
        Console.WriteLine($"a={a}, b ={b}");
        Console.WriteLine($"Addizione: a + b = {a + b}!");
        Console.WriteLine($"Sottrazione: a - b = {a - b}!");
        Console.WriteLine($"Moltiplicazione: a * b = {a * b}!");
        Console.WriteLine($"Divisione: a / b = {a / b}!");
        Console.WriteLine($"Modulo (resto): a % b = {a % b}!");
        Console.WriteLine("Operatori Assegnamento:");
        Console.WriteLine($"Incremento: a++ = {a++}!");
        Console.WriteLine($"Ora a = {a++}");
        Console.WriteLine($"Decremento: --b = {--b}");
        Console.WriteLine($"Ora b = {b}");

        Console.WriteLine("Operatori Logici:");
        Console.WriteLine($"AND: {a<b && a >= 10}");
        Console.WriteLine($"OR: {a>b || a >= 10}");
        Console.WriteLine($"NOT: {!(a<b)}");
    }

}



