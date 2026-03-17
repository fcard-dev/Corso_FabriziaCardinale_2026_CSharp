/* using System;
using MySql.Data.MySqlClient; // Libreria per la connessione a MySQL

class Program
{
    static void Main()
    {
        // Stringa di connessione: modifica user, password e nome del DB
        string connString = "server=localhost;user=root;password=root;database=csharp_test";

        // Creiamo una connessione con il database
        using (MySqlConnection conn = new MySqlConnection(connString))
        {
            try
            {
                conn.Open(); // Apertura connessione
                Console.WriteLine("Connessione riuscita!");

                // Query SQL per leggere il messaggio
                string query = "SELECT messaggio FROM saluto LIMIT 1";

                // Creazione del comando da eseguire
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Lettura dei risultati
                MySqlDataReader reader = cmd.ExecuteReader();

                // Se ci sono risultati, li stampiamo
                while (reader.Read())
                {
                    Console.WriteLine("Messaggio dal database: " + reader["messaggio"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore: " + ex.Message);
            }
        }
    }
}
 */