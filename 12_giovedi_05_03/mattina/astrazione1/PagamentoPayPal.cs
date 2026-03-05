public class PagamentoPayPal : GestioneImporto, IPagamento
{
    private string emailUtente;

    public string EmailUtente
    {
        get => emailUtente;
        set => emailUtente = value;
    }

    public override void MetodoPagamento()
    {
        Console.WriteLine($"con PayPal da {emailUtente}");
    }

    public void MostraMetodo()
    {
        Console.WriteLine($"Metodo: PayPal.");
    }
}