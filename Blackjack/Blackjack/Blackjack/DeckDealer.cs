using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class DeckDealer 
    {
        public int Waarde { get; set; }
        static public int Aantal { get; set; }
        public int TotaleWaarde { get; set; }

        static public void DealerDeckBouwen()
        {
            if (spel.FirstPull == true)
            {
                var z = spel.KaartStack.Pop();
                spel.Dealer.Add(z);
                Aantal++;
                var u = spel.KaartStack.Pop();
                spel.Dealer.Add(u);
                Aantal++;
                Console.WriteLine("De dealer heeft een " + spel.Dealer[spel.Dealer.Count - 1] + " en nog een kaart die je niet kan zien.");
            }
            else
            {
                var z = spel.KaartStack.Pop();
                spel.DeckSpeler.Add(z);
                Aantal++;
                Console.WriteLine("De dealer heeft een " + spel.Dealer[spel.Dealer.Count - 1] + " gekregen.");
            }
        }
        static public int WaardeBepalen(int totalewaarde2)
        {
            for (int i = 0; i < Aantal; i++)
            {
                int x = spel.Dealer[i].Waarde;
                totalewaarde2 = totalewaarde2 + x;
            }
            return totalewaarde2;
        }

    }
}
