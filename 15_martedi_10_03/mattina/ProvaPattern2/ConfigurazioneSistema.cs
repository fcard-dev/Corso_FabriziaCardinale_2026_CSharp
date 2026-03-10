public sealed class ConfigurazioneSistema
{
    private static Dictionary<string, string> configurazioni = new();

    private static ConfigurazioneSistema _istance = new();

    private ConfigurazioneSistema()
    {

    }

    public static ConfigurazioneSistema Istance
    {
        get => _istance;
    }

    public void Imposta(string chiave, string valore)
    {
        configurazioni[chiave] = valore;
    }

    public string Leggi(string chiave)
    {
        if (configurazioni.ContainsKey(chiave))
        {
            return configurazioni[chiave];
        }
        else
        {
            return "Chiave non presente";
        }
    }

    public void StampaTutto()
    {
        Console.WriteLine($"\nStampa Totale:");
        foreach (var c in configurazioni)
        {
            Console.WriteLine($"{c.Key} - {c.Value}");
        }
    }
}