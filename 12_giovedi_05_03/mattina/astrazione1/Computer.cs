public class Computer : DispositivoElettronico
{
    public override string Accendi()
    {
        return $"Il computer si avvia";
    }

     public override string Spegni()
    {
        return $"Il computer si spegne";
    }
}