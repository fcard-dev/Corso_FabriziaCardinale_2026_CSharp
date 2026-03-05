public class Badge
{
    private string _codice;
    private bool _isActive;

    public string Codice
    {
        get => _codice;
        set => _codice = value;
    }

    public bool IsActive
    {
        get => _isActive;
        set => _isActive = value;
    }
}