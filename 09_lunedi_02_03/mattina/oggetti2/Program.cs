using System;

class Program
{
    static void Main()
    {
        //Esercizio1();
        //Esercizio2();
        //Esercizio3();
        Esercizio4();
    }

    /* public static void Esercizio1()
    {
        Libro l = new Libro { Titolo = "Naruto", Autore = "Jirayia", AnnoPubblicazione = 2018 };
        Console.WriteLine(l);
        Console.WriteLine($"Oggetto di tipo {l.GetType()}");
    }

    public static void Esercizio2()
    {
        Libro l1 = new Libro { Titolo = "Harry Potter", Autore = "J.K.Rowling" };
        Libro l2 = new Libro { Titolo = "Harry Potter", Autore = "J.K.Rowling" };

        Console.WriteLine(l1.Equals(l2));
        Console.WriteLine(l1.Equals(l2));

        Console.WriteLine(ReferenceEquals(l1, l2));

    }

    public static void Esercizio3()
    {
        Libro l3 = new Libro { Titolo = "Harry Potter", Autore = "J.K.Rowling" };
        Libro l4 = new Libro { Titolo = "Harry Potter", Autore = "J.K.Rowling" };

        Console.WriteLine(l3.GetHashCode());
        Console.WriteLine(l4.GetHashCode());
    } */

    public static void Esercizio4()
    {
        List<Macchina> macchine = new();

        bool continua = true;

        Console.WriteLine($"Inserisci Nome: ");
        string n = Console.ReadLine();

        Random r = new();
        int c = r.Next(1, 10);

        Console.WriteLine($"Credito assegnato {c}");
        Console.WriteLine($"=========================");

        Utente u = new Utente { Nome = n, Credito = c };
        while (u.Credito > 0 && continua)
        {
            Console.WriteLine($"Inserisci tipo di motore: ");
            string m = Console.ReadLine();

            Console.WriteLine($"Inserisci velocità: ");
            float v = float.Parse(Console.ReadLine());

            Console.WriteLine($"Inserisci sospensioni: ");
            int s = int.Parse(Console.ReadLine());

            Macchina macchina = new Macchina
            {
                Motore = m,
                VelocitaMac = v,
                SospensioniMax = s,
                NrModifiche = 0
            };

            macchine.Add(macchina);
            bool modifica = true;
            while (u.Credito > 0 && modifica)
            {
                Console.WriteLine($"\nScegli tra le seguenti opzioni:");
                Console.WriteLine($"1- Aumento della velocità di 10");
                Console.WriteLine($"2- Cambio tipo di motore");
                Console.WriteLine($"3- Aumento delle sospensioni di 1");
                Console.WriteLine($"0- Esci");

                int scelta = int.Parse(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        macchina.VelocitaMac += 10;
                        macchina.NrModifiche++;
                        u.Credito--;
                        Console.WriteLine($"=====Velocità aumentata.=====");
                        break;
                    case 2:
                        Console.WriteLine($"Inserisci tipo di motore: ");
                        macchina.Motore = Console.ReadLine();
                        macchina.NrModifiche++;
                        u.Credito--;
                        Console.WriteLine($"=====Motore modificato.=====");
                        break;
                    case 3:
                        macchina.SospensioniMax += 1;
                        macchina.NrModifiche++;
                        u.Credito--;
                        Console.WriteLine($"=====Sospensioni aumentate.=====");
                        break;
                    case 0:
                        modifica = false;
                        Console.WriteLine($"=====Modifiche terminate.=====");
                        break;
                    default:
                        Console.WriteLine($"=====Scelta non consentita.=====");
                        break;
                }

            }
            if (u.Credito > 0)
            {
                Console.WriteLine($"\nVuoi modificare un'altra macchina? S/N ");
                string nm = Console.ReadLine();
                if (nm != "S")
                {
                    continua = false;
                }
            }
            else
            {
                Console.WriteLine($"=====Credito esaurito.=====");
                continua = false;
            }
        }
        Console.WriteLine($"\nRisultato finale: ");
        foreach (Macchina m in macchine)
        {
            Console.WriteLine($"Nome utente: {u.Nome}");
            Console.WriteLine($"Motore: {m.Motore}");
            Console.WriteLine($"Velocità: {m.VelocitaMac}");
            Console.WriteLine($"Sospensioni: {m.SospensioniMax}");
            Console.WriteLine($"Numero modifiche: {m.NrModifiche}");
        }
    }
}
