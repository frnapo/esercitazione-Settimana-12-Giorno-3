using System;

namespace es_Settimana_12_Giorno_3
{
    public class ContoCorrente
    {
        public decimal saldo { get; set; }
        public bool isOpen = false;
        public string nome { get; set; }
        public string cognome { get; set; }


        public void ApriConto()
        {
            if (isOpen)
            {
                Console.WriteLine("Il conto e' gia' aperto.");
                return;
            }
            Console.WriteLine("Inserisci il nome del correntista:");
            nome = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome del correntista:");
            cognome = Console.ReadLine();
            Console.WriteLine("Quanto desideri versare per l'apertura? (min. 1000€)");
            decimal primoVersamento = Convert.ToDecimal(Console.ReadLine());

            if (primoVersamento < 1000)
            {
                Console.WriteLine("Impossibile procedere con l'apertura, il versamento dev'essere superiore a 1000€");
            }
            else
            {
                saldo += primoVersamento;
                isOpen = true;
                Console.WriteLine($"Il conto n.123456789 e' stato aperto con successo! Nuovo saldo {saldo}");
            }

        }

        public void VisualizzaDettagli()
        {
            if (!isOpen)
            {
                Console.WriteLine("Nessun conto corrente associato! Aprire un conto per procedere.");
            }
            else
            {
                Console.WriteLine($"Ecco i dettagli per il conto n.123456789:\nNome: {nome} \nCognome: {cognome} \nSaldo: {saldo}");
            }
        }

        public void EffettuaVersamento()
        {
            if (!isOpen)
            {
                Console.WriteLine("Impossibile effettuare un versamento! Nessun conto corrente associato.");
                return;
            }


            Console.WriteLine("Inserisci un importo da versare:");
            decimal versamento = Convert.ToDecimal(Console.ReadLine());
            saldo += versamento;
            Console.WriteLine($"Versamento effettauto con successo! Nuovo saldo: {saldo}€");

        }

        public void EffettuaPrelievo()
        {
            if (!isOpen)
            {
                Console.WriteLine("Impossibile effettuare un prelievo! Nessun conto corrente associato.");
                return;
            }

            Console.WriteLine("Inserisci un importo da prelevare:");
            decimal prelievo = Convert.ToDecimal(Console.ReadLine());
            if (prelievo > saldo)
            {
                Console.WriteLine("Non puoi prelevare piu' della tua disponibilita'!");
            }
            else if (saldo <= 0)
            {
                Console.WriteLine("Saldo insufficiente!");
            }
            else
            {
                saldo -= prelievo;
                Console.WriteLine($"Prelievo effetuato con successo! Nuovo saldo: {saldo}€");
            }
        }

    }
}
