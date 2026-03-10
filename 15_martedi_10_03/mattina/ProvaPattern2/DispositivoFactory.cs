public class DispositivoFactory
{
    public static IDispositivo CreaDispositivo(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "computer": return new Computer();
            case "stampante": return new Stampante();
            default:
                Console.WriteLine($"Dispositivo errato.");
                return null;
        }
    }
}
