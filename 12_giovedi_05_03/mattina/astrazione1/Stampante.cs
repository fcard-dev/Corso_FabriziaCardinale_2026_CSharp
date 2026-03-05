public class Stampante : DispositivoElettronico
{
    public override string Accendi()
    {
        return $"La stampante si accende";
    }

     public override string Spegni()
    {
        return $"Stampante in standby";
    }
}