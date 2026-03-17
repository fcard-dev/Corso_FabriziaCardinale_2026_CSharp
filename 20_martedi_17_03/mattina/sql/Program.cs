using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
class Program
{
    static void Main()
    {
        // Esercizio1();
        Esercizio2();
    }

    public static void Esercizio1()
    {
        string connString = "server=localhost;user=root;password=root;database=rubrica_db";

        bool continua = true;

        while (continua)
        {
            Console.WriteLine("\n--- RUBRICA ---");
            Console.WriteLine("1. Inserisci contatto");
            Console.WriteLine("2. Visualizza contatti");
            Console.WriteLine("3. Elimina contatto");
            Console.WriteLine("0. Esci");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.WriteLine($"Inserisci nome:");
                    string nome = Console.ReadLine();
                    Console.WriteLine($"Inserisci numero:");
                    string telefono = Console.ReadLine();
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        try
                        {
                            conn.Open();
                            Console.WriteLine("Connessione riuscita!");
                            string query = "insert into contatti (nome, telefono) values (@nome, @telefono)";

                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@telefono", telefono);

                            cmd.ExecuteNonQuery();
                            Console.WriteLine($"\nContatto inserito con successo!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Errore: " + ex.Message);
                        }
                    }
                    break;
                case 2:
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        try
                        {
                            conn.Open();
                            Console.WriteLine("Connessione riuscita!");
                            string query = "SELECT * FROM contatti";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            Console.WriteLine("\nRubrica:");
                            while (reader.Read())
                            {
                                Console.WriteLine($"=======");
                                Console.WriteLine($"Id: {reader["id"]}");
                                Console.WriteLine($"Nome: {reader["nome"]}");
                                Console.WriteLine($"Telefono: {reader["telefono"]}");
                            }
                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Errore: " + ex.Message);
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine($"Inserisci nome del contatto da eliminare:");
                    string nomeDaEliminare = Console.ReadLine();
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        try
                        {
                            conn.Open();
                            Console.WriteLine("Connessione riuscita!");
                            string query = "delete from contatti where nome=@nome";

                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@nome", nomeDaEliminare);

                            int righe = cmd.ExecuteNonQuery();
                            if (righe > 0)
                            {
                                Console.WriteLine($"\nContatto eliminato con successo!");
                            }
                            else
                            {
                                Console.WriteLine($"Nessun contatto trovato!");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Errore: " + ex.Message);
                        }
                    }
                    break;
                case 0:
                    continua = false;
                    break;
                default:
                    Console.WriteLine($"Scelta errata.");
                    break;
            }
        }
    }

    public static void Esercizio2()
    {
        using var db = new ProdottiContext();

        db.Database.EnsureCreated();

        //create
        var p1 = new Prodotto { Nome = "SteamDeck", Prezzo = 450.80 };
        var p2 = new Prodotto { Nome = "Xbox series S", Prezzo = 299.99 };
        db.Prodotti.Add(p1);
        db.Prodotti.Add(p2);
        db.SaveChanges();
        Console.WriteLine($"Inserito prodotto con id {p1.Id}");
        Console.WriteLine($"Inserito prodotto con id {p2.Id}");

        //read
        var ricerca = db.Prodotti.Where(p => p.Nome == "SteamDeck").ToList();
        foreach (var r in ricerca)
        {
            Console.WriteLine($"{r.Id}, {r.Nome}, {r.Prezzo} ");
        }

        //update
        var modifica = db.Prodotti.FirstOrDefault();
        if (modifica != null)
        {
            modifica.Nome = "PS5";
            db.SaveChanges();
            Console.WriteLine($"Modifica effettuata al prodotto con id {modifica.Id}, ora ha nome {modifica.Nome}");
        }
    }
}

#region modello tabella
[Table("Prodotti")]
public class Prodotto
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    [Column("Nome")]
    public string Nome { get; set; }

    [Required]
    [Column("Prezzo")]
    public double Prezzo { get; set; }
}
#endregion

#region creo context
public class ProdottiContext : DbContext
{
    public DbSet<Prodotto> Prodotti { get; set; }

    // Connection string centrale (adatta server/credenziali al tuo ambiente)
    private const string ConnString =
        "server=localhost;user=root;password=root;database=prodotti";

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseMySql(ConnString, ServerVersion.AutoDetect(ConnString));
}
#endregion