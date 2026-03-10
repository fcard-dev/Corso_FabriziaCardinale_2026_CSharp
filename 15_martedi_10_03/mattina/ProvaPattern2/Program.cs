public class Program
{

    public static void Main()
    {

        ModuloA mA = new();
        ModuloB mB = new();
        IDispositivo dispositivo = null;
        List<IDispositivo> dispositivi = new();
        bool continua = true;
        while (continua)
        {
            Console.WriteLine("\nSeleziona opzione:");
            Console.WriteLine("1 - Crea stampante di default");
            Console.WriteLine("2 - Crea computer di default");
            Console.WriteLine("3 - Crea stampante");
            Console.WriteLine("4 - Crea computer");
            Console.WriteLine("5 - Avvia dispositivi");
            Console.WriteLine("6 - Mostra tipi");
            Console.WriteLine("7 - Verifica istanze");
            Console.WriteLine("8 - Stampa tutto");
            Console.WriteLine("0 - Esci");
            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    dispositivo = mA.Do();
                    dispositivi.Add(dispositivo);
                    Console.WriteLine($"Stampante di default creata.");
                    break;
                case 2:
                    dispositivo = mB.Do();
                    dispositivi.Add(dispositivo);
                    Console.WriteLine($"Computer di default creato.");
                    break;
                case 3:
                    Console.WriteLine($"Inserisci marca:");
                    string marcaStampante = Console.ReadLine();
                    dispositivo = DispositivoFactory.CreaDispositivo("stampante");
                    dispositivi.Add(dispositivo);
                    ConfigurazioneSistema.Istance.Imposta("Stampante", marcaStampante);
                    Console.WriteLine($"Stampante creata.");
                    break;
                case 4:
                    Console.WriteLine($"Inserisci marca:");
                    string marcaPC = Console.ReadLine();
                    dispositivo = DispositivoFactory.CreaDispositivo("computer");
                    dispositivi.Add(dispositivo);
                    ConfigurazioneSistema.Istance.Imposta("Computer", marcaPC);
                    Console.WriteLine($"Computer creato.");
                    break;
                case 5:
                    if (dispositivi.Count > 0)
                    {
                        foreach (var d in dispositivi)
                        {
                            d.Avvia();
                        }
                    }
                    break;
                case 6:
                    if (dispositivi.Count > 0)
                    {
                        foreach (var d in dispositivi)
                        {
                            d.MostraTipo();
                        }
                    }
                    break;
                case 7:
                    var v1 = ConfigurazioneSistema.Istance;
                    var v2 = ConfigurazioneSistema.Istance;

                    Console.WriteLine($"Controllo istanza: {ReferenceEquals(v1, v2)}");
                    break;
                case 8:
                    ConfigurazioneSistema.Istance.StampaTutto();
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