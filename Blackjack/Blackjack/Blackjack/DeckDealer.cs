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
                spel.Dealer.Add(z);
                Aantal++;
                Console.WriteLine("De kaarten in de hand van de dealer zijn:");
                int x = spel.DeckSpeler.Count; //hoeveelheid kaarten in hand
                string DealerKaarten = "";
                for (int i = 0; i < x; i++)
                {
                    DealerKaarten = DealerKaarten + spel.DeckSpeler[i] + " ";
                }
                //laten zien hoeveel kaarten je hebt en de totaalwaarde.
                Console.WriteLine(DealerKaarten);
                var WaardeDealer = DeckDealer.WaardeBepalen(0);
                Console.WriteLine("De totaalwaarde van de kaarten van de dealer is " + WaardeDealer + ".");
                if (WaardeDealer < 17)
                {
                    Console.WriteLine("De dealer gaat nog een keer trekken.");
                }
                else { }

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
