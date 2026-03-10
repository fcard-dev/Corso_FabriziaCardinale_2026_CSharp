public interface IBevanda
{
    public string Descrizione();
    public double Costo();
}

public class Caffe : IBevanda
{
    public string Descrizione()
    {
        return "Caffè";
    }

    public double Costo()
    {
        return 1.10;
    }
}

public class Te : IBevanda
{
    public string Descrizione()
    {
        return "Tè";
    }

    public double Costo()
    {
        return 2.30;
    }
}

public abstract class DecoratoreBevanda : IBevanda
{
    protected IBevanda _bevanda;

    protected DecoratoreBevanda(IBevanda bevanda)
    {
        _bevanda = bevanda;
    }

    public virtual string Descrizione()
    {
        return _bevanda.Descrizione();
    }
    public virtual double Costo()
    {
        return _bevanda.Costo();
    }
}

public class ConLatte : DecoratoreBevanda
{
    public ConLatte(IBevanda bevanda) 
        : base(bevanda) { }

    public override string Descrizione()
    {
        return $"{base.Descrizione()} con latte" ;
    }

    public override double Costo()
    {
        return base.Costo()+ 0.50;
    }
}

public class ConCioccolato : DecoratoreBevanda
{
    public ConCioccolato(IBevanda bevanda) 
        : base(bevanda) { }

    public override string Descrizione()
    {
        return $"{base.Descrizione()} con cioccolato" ;
    }

    public override double Costo()
    {
        return base.Costo()+ 0.70;
    }
}

public class ConPanna : DecoratoreBevanda
{
    public ConPanna(IBevanda bevanda) 
        : base(bevanda) { }

    public override string Descrizione()
    {
        return $"{base.Descrizione()} con panna" ;
    }

    public override double Costo()
    {
        return base.Costo()+ 0.80;
    }
}


