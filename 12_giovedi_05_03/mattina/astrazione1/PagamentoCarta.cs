public class PagamentoCarta : GestioneImporto, IPagamento
{
    private string circuito;

    public string Circuito
    {
        get => circuito;
        set => circuito = value;
    }

    public override void MetodoPagamento()
    {
        Console.WriteLine($" con circuito {Circuito}");
    }

    public void MostraMetodo()
    {
        Console.WriteLine($"Metodo: Carta di credito.");
    }
}