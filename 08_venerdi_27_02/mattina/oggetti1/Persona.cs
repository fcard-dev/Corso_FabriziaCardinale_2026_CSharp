public class Persona
{
    public string Nome;
    public string Cognome;
    public int AnnoNascita;
    
    public Persona(string nome, string cognome, int annoNascita)
    {
        Nome = nome;
        Cognome = cognome;
        AnnoNascita = annoNascita;
    }
    
    public void Descrivi()
    {
        Console.WriteLine($"{Nome} {Cognome} è nato/a nel {AnnoNascita}");
    }
}