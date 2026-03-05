public abstract class Persona
{
    private string _nome;
    private string _cognome;
    public Badge badge;
    public string Nome
    {
        get => _nome;
        set => _nome = value;
    }

    public string Cognome
    {
        get => _cognome;
        set => _cognome = value;
    }

    public abstract string RuoloDipendente();

}