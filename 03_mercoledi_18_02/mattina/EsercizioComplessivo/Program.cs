using System;

class Program
{
    static void Main(string[] args)
    {
        /*vai a creare un sistema che permetta di registrare i dati nome e password
        poi fai un sistema che accetti in input un nome ed una password e ti faccia accedere al sistema
        solo se corrispondono a quelli precedentemente registrati
        se accedi devi poter usare un for per attivare un conto alla rovescia
        il tutto deve ripetersi quante volte vuole l'utente e le scelte devono essere in uno switch*/
        string nomeScelto = "";
        string passwordScelta = "";
        string scelta = "";

        while (scelta != "3")
        {
            Console.WriteLine("Scegli tra le seguenti opzioni: ");
            Console.WriteLine("1. Registrazione");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Esci");
            scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    Console.Write("Inserisci Nome: ");
                    nomeScelto = Console.ReadLine();
                    Console.Write("Inserisci password: ");
                    passwordScelta = Console.ReadLine();
                    Console.WriteLine("Registrazione effettuata.");
                    break;
                case "2":
                    Console.Write("Inserisci Nome: ");
                    string nomeLogin = Console.ReadLine();
                    Console.Write("Inserisci password: ");
                    string passwordLogin = Console.ReadLine();

                    if (nomeLogin == nomeScelto && passwordLogin == passwordScelta)
                    {
                        Console.WriteLine("Accesso effettuato.");
                        string cr = "";
                        do
                        {
                            Console.Write("Inserisci un numero per il conto alla rovescia: ");
                            string n = Console.ReadLine();
                            int intN = int.Parse(n);

                            for (int i = intN; i != 0; i--)
                            {
                                Console.WriteLine(i);
                            }

                            do
                            {
                                Console.WriteLine("Vuoi fare un altro conto alla rovescia?");
                                Console.WriteLine("S-Si ");
                                Console.WriteLine("N-No ");
                                cr = Console.ReadLine();
                                if (cr != "S" && cr != "N")
                                {
                                    Console.WriteLine("Selezione errata, riprova");
                                }
                            } while (cr != "S" && cr != "N");
                        } while (cr == "S");
                    }
                    else
                    {
                        Console.WriteLine("Accesso negato");
                    }
                    break;
                case "3":
                    Console.WriteLine("Uscita.");
                    scelta = "3";
                    break;
                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }
    }
}