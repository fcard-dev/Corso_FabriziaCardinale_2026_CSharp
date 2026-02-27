public class Operazioni
{
    public int Somma(int a, int b)
    {
        return a + b;
    }

    public int Moltiplicazione(int a, int b)
    {
        return a * b;
    }

    public void StampaRisultato(string operazione, int risultato)
    {
       Console.WriteLine($"{operazione} è {risultato} ");
    }

}