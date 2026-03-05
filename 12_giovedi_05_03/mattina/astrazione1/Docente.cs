public class Docente
{
    private string nome;
    private string materia;

    public string Nome
    {
        get => nome;
        set
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
            {
                nome = value;
            }
            else
            {
                Console.WriteLine($"Nome non valido.");
            }
        }
    }

    public string Materia
    {
        get => materia;
        set
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
            {
                materia = value;
            }
            else
            {
                Console.WriteLine($"Materia non valida.");
            }
        }
    }
}