class Program
{
    static void Main()
    {
        //Esercizio1();
        //Esercizio2();
        Esercizio3();
    }

    public static void Esercizio1()
    {
        Console.WriteLine("\nChe veicolo vuoi creare? ");
        string tipoVeicolo = Console.ReadLine();

        IVeicolo v = VeicoloFactory.CreaVeicolo(tipoVeicolo);

        if (v != null)
        {
            v.Avvia();
            v.MostraTipo();
        }
    }

    public static void Esercizio2()
    {
        bool continua = true;
        while (continua)
        {
            Console.WriteLine("\nCosa vuoi disegnare?");
            Console.WriteLine("1 - Cerchio");
            Console.WriteLine("2 - Quadrato");
            Console.WriteLine("0 - Esci");
            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());

            ShapeCreator creator;
            IShape shape;

            switch (scelta)
            {
                case 1:
                    creator = new ConcreteShapeCreatorA();
                    shape = creator.CreateShape("circle");
                    shape.Draw();
                    break;
                case 2:
                    creator = new ConcreteShapeCreatorB();
                    shape = creator.CreateShape("square");
                    shape.Draw();
                    break;
                case 0:
                    continua = false;
                    break;
                default:
                    Console.WriteLine($"Scelta non valida");
                    break;
            }
        }
    }

    public static void Esercizio3()
    {
        bool continua = true;
        while (continua)
        {

            Console.WriteLine("\nScegli veicolo da creare");
            Console.WriteLine("1 - Auto");
            Console.WriteLine("2 - Moto");
            Console.WriteLine("3 - Camion");
            Console.WriteLine("0 - Esci");
            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());

            string tipo = "";

            switch (scelta)
            {
                case 1:
                    tipo = "auto";
                    break;
                case 2:
                    tipo = "moto";
                    break;
                case 3:
                    tipo = "camion";
                    break;
                case 0:
                    continua = false;
                    continue;
                default:
                    Console.WriteLine($"Scelta non valida");
                    continue;
            }

            IVeicolo v = VeicoloFactory.CreaVeicolo(tipo);
            Console.WriteLine($"\nVeicolo {tipo} creato.");
            

            if (v != null)
            {
                v.Avvia();

                RegistroVeicoli registro = RegistroVeicoli.GetIstanza();
                registro.Registra(v);
                registro.StampaTutti();
            }
        }
    }
}