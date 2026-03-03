using System;

class Program
{
    static void Main()
    {
        Esercizio1();
        Esercizio2();

    }

    public static void Esercizio1()
    {
        List<Veicolo> veicoli = new();

        Auto a = new();
        a.Targa = "12345";
        veicoli.Add(a);

        Moto m = new();
        m.Targa = "abcde";
        veicoli.Add(m);

        Camion c = new();
        c.Targa = "123ab";
        veicoli.Add(c);

        foreach (var v in veicoli)
        {
            Console.WriteLine($"Targa: {v.Targa} + {v.Ripara()}");
        }
    }

    public static void Esercizio2()
    {
        List<Operatore> operatori = new();
        bool continua = true;
        while (continua)
        {
            Console.WriteLine($"\nScegli tra le seguenti opzioni:");
            Console.WriteLine($"1- Aggiungi operatore");
            Console.WriteLine($"2- Stampa elenco operatori");
            Console.WriteLine($"3- Esegui compiti degli operatori");
            Console.WriteLine($"0- Esci");

            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.WriteLine($"\nChe tipo di operatore vuoi inserire? ");
                    Console.WriteLine($"1- Emergenza");
                    Console.WriteLine($"2- Sicurezza");
                    Console.WriteLine($"3- Logistico");

                    int tipoOperatore = int.Parse(Console.ReadLine());

                    switch (tipoOperatore)
                    {
                        case 1:
                            Console.WriteLine($"Inserisci nome: ");
                            string nomeOperatoreEmergenza = Console.ReadLine();
                            Console.WriteLine($"Inserisci turno giorno/notte: ");
                            string turnoOperatoreEmergenza = Console.ReadLine();
                            Console.WriteLine($"Inserisci livello urgenza (1-5): ");
                            int urgenza = int.Parse(Console.ReadLine());

                            OperatoreEmergenza oe = new OperatoreEmergenza
                            {
                                Nome = nomeOperatoreEmergenza,
                                Turno = turnoOperatoreEmergenza,
                                LivelloUrgenza = urgenza
                            };
                            operatori.Add(oe);
                            Console.WriteLine($"=====Operatore d'emergenza inserito.=====");
                            break;
                        case 2:
                            Console.WriteLine($"Inserisci nome: ");
                            string nomeOperatoreSicurezza = Console.ReadLine();
                            Console.WriteLine($"Inserisci turno giorno/notte: ");
                            string turnoOperatoreSicurezza = Console.ReadLine();
                            Console.WriteLine($"Inserisci area sorvegliata: ");
                            string area = Console.ReadLine();

                            OperatoreSicurezza os = new OperatoreSicurezza
                            {
                                Nome = nomeOperatoreSicurezza,
                                Turno = turnoOperatoreSicurezza,
                                areaSorvegliata = area
                            };
                            operatori.Add(os);
                            Console.WriteLine($"=====Operatore di sicurezza inserito.=====");
                            break;
                        case 3:
                            Console.WriteLine($"Inserisci nome: ");
                            string nomeOperatoreLogistica = Console.ReadLine();
                            Console.WriteLine($"Inserisci turno giorno/notte: ");
                            string turnoOperatoreLogistica = Console.ReadLine();
                            Console.WriteLine($"Inserisci numero consegne: ");
                            int consegne = int.Parse(Console.ReadLine());

                            OperatoreLogistica ol = new OperatoreLogistica
                            {
                                Nome = nomeOperatoreLogistica,
                                Turno = turnoOperatoreLogistica,
                                NumeroConsegne = consegne
                            };
                            operatori.Add(ol);
                            Console.WriteLine($"=====Operatore di logistica inserito.=====");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine($"=====Operatori d'emergenza=====");
                    foreach (var o in operatori)
                    {
                        if (o is OperatoreEmergenza operatoreEmergenza)
                        {
                            Console.WriteLine($"Nome: {operatoreEmergenza.Nome} | Turno: {operatoreEmergenza.Turno} | Livello di urgenza: {operatoreEmergenza.LivelloUrgenza}");
                        }
                    }

                    Console.WriteLine($"=====Operatori di sicurezza=====");
                    foreach (var o in operatori)
                    {
                        if (o is OperatoreSicurezza operatoreSicurezza)
                        {
                            Console.WriteLine($"Nome: {operatoreSicurezza.Nome} | Turno: {operatoreSicurezza.Turno} | Area sorvegliata: {operatoreSicurezza.areaSorvegliata}");
                        }
                    }
                    Console.WriteLine($"=====Operatori di logistica=====");
                    foreach (var o in operatori)
                    {
                        if (o is OperatoreLogistica operatoreLogistica)
                        {
                            Console.WriteLine($"Nome: {operatoreLogistica.Nome} | Turno: {operatoreLogistica.Turno} | Numero di consegne: {operatoreLogistica.NumeroConsegne}");
                        }
                    }
                    break;
                case 3:
                    foreach (var o in operatori)
                    {
                        Console.WriteLine(o.EseguiCompito());
                    }
                    break;
                case 0:
                    continua = false;
                    Console.WriteLine($"=====Uscita in corso.=====");
                    break;
                default:
                    Console.WriteLine($"=====Scelta non consentita.=====");
                    break;
            }
        }
    }
}