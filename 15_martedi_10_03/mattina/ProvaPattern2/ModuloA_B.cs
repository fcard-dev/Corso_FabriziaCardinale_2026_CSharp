public class ModuloA
{
    public IDispositivo Do()
    {
        var config = ConfigurazioneSistema.Istance;
        config.Imposta("Stampante", "HP");
        string valore = config.Leggi("Stampante");
        Console.WriteLine($"{valore}");
        return DispositivoFactory.CreaDispositivo("stampante");
    }
}

public class ModuloB
{
    public IDispositivo Do()
    {
        var config = ConfigurazioneSistema.Istance;
        config.Imposta("Computer", "Lenovo");
        string valore = config.Leggi("Computer");
        Console.WriteLine($"{valore}");
        return DispositivoFactory.CreaDispositivo("computer");
    }
}