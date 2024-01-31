using System;

namespace es_Settimana_12_Giorno_3
{
    internal class ArrayNumeri
    {
        public int[] numeri = new int[3];

        public void InserisciNumeri()
        {
            Console.WriteLine("Inserisci 3 numeri nell'array:");

            for (int i = 0; i < numeri.Length; i++)
            {
                Console.WriteLine("\n Inserisci numero" + i);
                numeri[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
        }
        public void CalcolaSommaeMediaNumeri()
        {
            int somma = 0;
            for (int i = 0; i < numeri.Length; i++)
            {
                somma += numeri[i];
            }
            int media = somma / numeri.Length;
            Console.WriteLine($"La somma dei numeri dell'array e': {somma}");
            Console.WriteLine($"La media dei numeri dell'array e': {media}");
            Console.ReadKey();
        }


    }
}
