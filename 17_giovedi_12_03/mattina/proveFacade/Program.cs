public class Program
{
    public static void Main()
    {
        Esercizio1();
    }


    public static void Esercizio1()
    {
        GamingSetupFacade postazione = GamingSetupFacade.istanza;

        Log log = new();
        postazione.Registra(log);

        postazione.AvviaPostazione();

        postazione.SpegniPostazione();
    }
}