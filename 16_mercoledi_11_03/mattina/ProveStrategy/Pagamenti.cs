#region strategy
public interface IPaymentStrategy
{
    public void Pay(decimal amount);
}

public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pagamento con carta di credito di {amount}");
    }
}

public class PayPalPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pagamento con paypal di {amount}");
    }
}

public class BitcoinPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pagamento con bitcoin di {amount}");
    }
}

public class PaymentContext
{
    private IPaymentStrategy _strategy;

    public void SetStrategy(IPaymentStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Pay(decimal amount)
    {
        if (_strategy == null)
        {
            Console.WriteLine("Nessuna strategia impostata.");
            return;
        }
        _strategy.Pay(amount);
    }
}
#endregion

#region factory

public class PaymentFactory
{
    public static IPaymentStrategy CreaPagamento(int scelta)
    {
        switch (scelta)
        {
            case 1: return new CreditCardPayment();
            case 2: return new PayPalPayment();
            case 3: return new BitcoinPayment();
            default:
                Console.WriteLine($"Scelta errata.");
                return null;
        }
    }
}
#endregion