public class Program
{
    static void Main(string[] args)
    {
        //Esercizio1();
        Esercizio2();
    }

    public static void Esercizio1()
    {
        IBevanda bevanda1 = new Caffe();
        IBevanda bevanda2 = new Te();

        bevanda1 = new ConCioccolato(bevanda1);
        bevanda2 = new ConLatte(bevanda2);
        bevanda1 = new ConPanna(bevanda1);

        Console.WriteLine(bevanda1.Descrizione());
        Console.WriteLine(bevanda1.Costo());

        Console.WriteLine(bevanda2.Descrizione());
        Console.WriteLine(bevanda2.Costo());
    }

    public static void Esercizio2()
    {
        GestoreTorta gestore = GestoreTorta.Istanza;
        ModuloLog mLog = new();

        gestore.Registra(mLog);

        bool continua = true;
        while (continua)
        {
            Console.WriteLine("\nSeleziona la base della torta:");
            Console.WriteLine("1 - Cioccolato");
            Console.WriteLine("2 - Vaniglia");
            Console.WriteLine("3 - Frutta");
            Console.WriteLine("0 - Esci");
            Console.Write("Scelta: ");
            int baseTorta = int.Parse(Console.ReadLine());

            ITorta torta = null;
            switch (baseTorta)
            {
                case 1:
                    torta = gestore.CreaTorta("cioccolato");
                    break;
                case 2:
                    torta = gestore.CreaTorta("vaniglia");
                    break;
                case 3:
                    torta = gestore.CreaTorta("frutta");
                    break;
                case 0:
                    continua = false;
                    continue;
                default:
                    Console.WriteLine($"Scelta non valida");
                    continue;
            }
            gestore.Notifica("Base creata.");

            bool decorazione = true;
            while (decorazione)
            {
                Console.WriteLine("\nSeleziona il gusto della torta:");
                Console.WriteLine("1 - Panna");
                Console.WriteLine("2 - Fragole");
                Console.WriteLine("3 - Glassa");
                Console.WriteLine("0 - Esci");
                Console.Write("Scelta: ");
                int gustoTorta = int.Parse(Console.ReadLine());

                switch (gustoTorta)
                {
                    case 1:
                        torta = new ConPanna1(torta, gestore);
                        break;
                    case 2:
                        torta = new ConFragole(torta,gestore); ;
                        break;
                    case 3:
                        torta = new ConGlassa(torta,gestore);
                        break;
                    case 0:
                        decorazione = false;
                        continua = false;
                        break;
                    default:
                        Console.WriteLine($"Scelta non valida");
                        break;
                }
            }
            Console.WriteLine($"\nTorta finale: {torta.Descrizione()}");
        }
    }
}