using System;

namespace es_Settimana_12_Giorno_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool esci = false;
            ContoCorrente nuovoConto = new ContoCorrente();
            ArrayNomi arrayNomi = new ArrayNomi();
            ArrayNumeri arrayNumeri = new ArrayNumeri();


            while (!esci)
            {
                Console.WriteLine("\n-----HOME BANKING-----\n");
                Console.WriteLine("1. Apri un conto corrente");
                Console.WriteLine("2. Dettagli conto corrente");
                Console.WriteLine("3. Effettua un versamento");
                Console.WriteLine("4. Effettua un prelievo");
                Console.WriteLine("\n \n-----------------ARRAY NOMI----------------\n");
                Console.WriteLine("5. Inserisci nomi nell'array");
                Console.WriteLine("6. Trova nomi nell'array");
                Console.WriteLine("\n \n-----------------ARRAY NUMERI----------------\n");
                Console.WriteLine("7. Inserisci numeri nell'array");
                Console.WriteLine("8. Calcola somma e media nell'array");
                Console.WriteLine("\n9. Esci\n");
                Console.Write("Seleziona un'opzione: ");
                byte opzione = Convert.ToByte(Console.ReadLine());

                switch (opzione)
                {
                    case 1:
                        nuovoConto.ApriConto();
                        break;
                    case 2:
                        nuovoConto.VisualizzaDettagli();
                        break;
                    case 3:
                        nuovoConto.EffettuaVersamento();
                        break;
                    case 4:
                        nuovoConto.EffettuaPrelievo();
                        break;
                    case 5:
                        arrayNomi.InserisciNomi();
                        break;
                    case 6:
                        arrayNomi.CercaNome();
                        break;
                    case 7:
                        arrayNumeri.InserisciNumeri();
                        break;
                    case 8:
                        arrayNumeri.CalcolaSommaeMediaNumeri();
                        break;
                    case 9:
                        esci = true;
                        break;
                    default:
                        Console.WriteLine("Opzione non valida! Si prega di riprovare.")
                    ; break;
                }
            }
        }
    }
}
