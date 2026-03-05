public class PagamentoContanti : GestioneImporto, IPagamento
{
    public override void MetodoPagamento()
    {
        Console.WriteLine($"con contanti.");
    }

    public void MostraMetodo()
    {
        Console.WriteLine($"Metodo: Contanti.");
    }
}