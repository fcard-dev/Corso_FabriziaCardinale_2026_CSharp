public interface IPaymentGateway
{
    void Pay(double cifra);
}

public class PaypalGateway : IPaymentGateway
{
    public void Pay(double cifra)
    {
        Console.WriteLine($"Pagato {cifra} con paypal");
    }
}

public class StripeGateway : IPaymentGateway
{
    public void Pay(double cifra)
    {
        Console.WriteLine($"Pagato {cifra} con stripe");
    }
}


public class PaymentService
{
    private readonly IPaymentGateway _payment;

    public PaymentService(IPaymentGateway payment)
    {
        _payment = payment;
    }

    public void Paga(double cifra)
    {
        _payment.Pay(cifra);
    }
}