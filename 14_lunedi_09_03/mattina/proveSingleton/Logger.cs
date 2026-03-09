public sealed class Logger
{
    private static Logger _istance;

    private Logger()
    {
        
    }
    public static Logger GetIstanza()
    {
        if (_istance == null)
        {
            _istance = new Logger();
        }
        return _istance;
    }

    public void ScriviMessaggio(string messaggio)
    {
        Console.WriteLine($"Logger1: {DateTime.Now} - {messaggio}");
    }
}