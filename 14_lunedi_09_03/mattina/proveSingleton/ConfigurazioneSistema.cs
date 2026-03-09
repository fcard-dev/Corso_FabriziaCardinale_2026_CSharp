public sealed class ConfigurazioneSistema
{
    private Dictionary<string, string> _config;
    private static ConfigurazioneSistema _istance = new();
    private ConfigurazioneSistema()
    {
        _config = new();
    }

    public static ConfigurazioneSistema Istance
    {
        get => _istance;
    }

    public void Imposta(string chiave, string valore)
    {
        _config[chiave] = valore;
    }

    public string Leggi(string chiave)
    {
        if (_config.ContainsKey(chiave))
        {
            return _config[chiave];
        }
        else
        {
            return "Chiave non presente";
        }
    }

    public void StampaTutte()
    {
        Console.WriteLine($"\nStampa totale:");
        
        foreach (var c in _config)
        {
            Console.WriteLine($"{c.Key} - {c.Value}");
        }
    }
}