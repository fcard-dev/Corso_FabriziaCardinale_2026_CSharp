public class Dipendente : Persona
{
    private string _turno;

    public string Turno
    {
        get => _turno;
        set => _turno = value;
    }

    public override string RuoloDipendente()
    {
        return $"Sono un dipendente";
    }
}