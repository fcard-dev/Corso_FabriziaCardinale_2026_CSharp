public sealed class Logger2
{
    private static Logger2 _istance2;

    private Logger2()
    {
        
    }
    public static Logger2 GetIstanza()
    {
        if (_istance2 == null)
        {
            _istance2 = new Logger2();
        }
        return _istance2;
    }

    public void ScriviMessaggio(string messaggio)
    {
        Console.WriteLine($"Logger2: {DateTime.Now} - {messaggio}");
    }
}