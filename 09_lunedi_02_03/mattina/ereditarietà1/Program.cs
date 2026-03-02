using System;

class Program
{
    static void Main()
    {
        //Esercizio1();
        Esercizio2();
    }

    public static void Esercizio1()
    {
        List<Veicolo> garage = new();

        bool continua = true;

        while (continua)
        {
            Console.WriteLine($"\nScegli tra le seguenti opzioni:");
            Console.WriteLine($"1- Inserisci nuova auto.");
            Console.WriteLine($"2- Inserisci nuova moto.");
            Console.WriteLine($"3- Visualizza veicoli");
            Console.WriteLine($"0- Esci");

            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.WriteLine($"Marca: ");
                    string marcaAuto = Console.ReadLine();
                    Console.WriteLine($"Modello: ");
                    string modelloAuto = Console.ReadLine();
                    Console.WriteLine($"Numero di porte: ");
                    int porte = int.Parse(Console.ReadLine());

                    Auto nuovaAuto = new Auto
                    {
                        Marca = marcaAuto,
                        Modello = modelloAuto,
                        NumeroPorte = porte,
                    };
                    garage.Add(nuovaAuto);
                    Console.WriteLine($"=====Auto inserita.=====");
                    break;
                case 2:
                    Console.WriteLine($"Marca: ");
                    string marcaMoto = Console.ReadLine();
                    Console.WriteLine($"Modello: ");
                    string modelloMoto = Console.ReadLine();
                    Console.WriteLine($"Tipo di manubrio: ");
                    string manubrio = Console.ReadLine();

                    Moto nuovaMoto = new Moto
                    {
                        Marca = marcaMoto,
                        Modello = modelloMoto,
                        TipoManubrio = manubrio,
                    };
                    garage.Add(nuovaMoto);
                    Console.WriteLine($"=====Moto inserita.=====");
                    break;
                case 3:
                    Console.WriteLine($"\nGarage: ");
                    foreach (Veicolo v in garage)
                    {
                        v.StampaInfo();
                    }
                    break;
                case 0:
                    continua = false;
                    Console.WriteLine($"=====Garage aggiornato.=====");
                    break;
                default:
                    Console.WriteLine($"=====Scelta non consentita.=====");
                    break;
            }
        }
    }

    public static void Esercizio2()
    {
        VoloAereo volo = new();
        volo.CodiceVolo = 12345;

        bool continua = true;

        while (continua)
        {
            Console.WriteLine($"\nScegli l'opzione:");
            Console.WriteLine($"1-Effettua prenotazione");
            Console.WriteLine($"2-Annulla prenotazione");
            Console.WriteLine($"0-Esci");

            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.WriteLine($"Quanti posti vuoi prenotare? ");
                    int postiPrenotati = int.Parse(Console.ReadLine());
                    volo.EffettuaPrenotazione(postiPrenotati);
                    volo.VisualizzaStato();
                    break;
                case 2:
                    Console.WriteLine($"Quanti posti vuoi annullare? ");
                    int postiAnnullati = int.Parse(Console.ReadLine());
                    volo.AnnullaPrenotazione(postiAnnullati);
                    volo.VisualizzaStato();
                    break;
                case 0:
                    continua = false;
                    break;
                default:
                    Console.WriteLine($"=====Scelta non consentita.=====");
                    break;
            }
        }
    }
}