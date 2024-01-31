using System;

namespace es_Settimana_12_Giorno_3
{
    public class ArrayNomi
    {
        public string[] nomi = new string[3];

        public void InserisciNomi()
        {
            Console.WriteLine("Inserisci 3 nomi nell'array:");

            for (int i = 0; i < nomi.Length; i++)
            {
                Console.WriteLine("\n Inserisci Nome" + i);
                nomi[i] = Console.ReadLine();
            }
            Console.ReadKey();
        }

        public void CercaNome()
        {
            Console.Write("Inserisci il nome da cercare: ");
            string nomeDaCercare = Console.ReadLine();

            bool trovato = false;

            foreach (string nome in nomi)
            {
                if (nomeDaCercare == nome)
                {
                    Console.WriteLine($"{nomeDaCercare} è presente nell'array :)");
                    trovato = true;
                    Console.ReadKey();
                    break;
                }
            }

            if (!trovato)
            {
                Console.WriteLine($"{nomeDaCercare} non è presente nell'array :(");
                Console.ReadKey();
            }
        }
    }
}
