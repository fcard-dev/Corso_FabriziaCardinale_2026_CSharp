public abstract class GestioneImporto
{
    public void EseguiPagamento(decimal importo)
    {
        Console.Write($"Pagamento di {importo} Euro ");
        MetodoPagamento();
    }

    public abstract void MetodoPagamento();
}