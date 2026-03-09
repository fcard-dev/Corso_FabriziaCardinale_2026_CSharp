public sealed class RegistroVeicoli
{
    private static RegistroVeicoli _istance = new();
    private static List<IVeicolo> veicoliCreati = new();

    private RegistroVeicoli()
    {

    }

    public static RegistroVeicoli GetIstanza()
    {
        return _istance;
    }

    public void Registra(IVeicolo veicolo)
    {
        veicoliCreati.Add(veicolo);
    }

    public void StampaTutti()
    {
        Console.WriteLine($"\nStampa totale:");

        foreach (var v in veicoliCreati)
        {
            v.MostraTipo();
        }
    }
}