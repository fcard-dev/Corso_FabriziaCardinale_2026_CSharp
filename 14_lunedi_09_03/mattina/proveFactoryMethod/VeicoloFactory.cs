public static class VeicoloFactory
{
   public static IVeicolo CreaVeicolo(string tipo)
    {
        switch (tipo)
        {
            case "auto": return new Auto();
            case "moto": return new Moto();
            case "camion": return new Camion();
            default:
                Console.WriteLine($"Veicolo errato");
                return null;
        }
    }
}