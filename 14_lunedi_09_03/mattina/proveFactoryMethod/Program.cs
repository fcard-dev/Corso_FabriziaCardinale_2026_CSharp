class Program
{
    static void Main()
    {
        //Esercizio1();
        Esercizio2();
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
}