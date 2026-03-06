public abstract class Animale
{
    private string _nome;
    private int _eta;

    //proprietà
    public string Nome
    {
        get => _nome;
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && !string.IsNullOrEmpty(value))
            {
                _nome = value;
            }
            else
            {
                Console.WriteLine($"Nome non valido");
            }
        }
    }

    public int Eta
    {
        get => _eta;
        set
        {
            if (value >= 0)
            {
                _eta = value;
            }
            else
            {
                Console.WriteLine($"Età non valida");
            }
        }
    }

    //costruttore
    public Animale(string _nome, int _eta)
    {
        Nome = _nome;
        Eta = _eta;
    }

//metodo per info
    public virtual string MostraInfo()
    {
        return $"{Nome} ha {Eta} anni.";
    }

//metodo per verso
    public abstract void Verso();

}