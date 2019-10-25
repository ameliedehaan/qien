using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Player
    {
        public string name;
        //static public string hand;
        public int totaalwaarde;
        public bool pas;
        static public List<DeckPlayer> Hand = new List<DeckPlayer>();
        public int aantal;


        public Player(string speler)
        {
            name = speler;
            //hand = [0];
            totaalwaarde = 0;
            pas = false;
            aantal = 0;
        }

        public string Name { get { return name; } }
       // public string Hand { get { return hand; } }
        public int TotaalWaarde { get { return totaalwaarde; } set { } }
        public bool Pas { get { return pas; } }
        //public Hand {get {
        static public int Aantal { get; set; }


        static public void SpelerDeckBouwen()
        {
            if (spel.FirstPull == true)
            {
                var z = spel.KaartStack.Pop();
                Hand.Add(z);
                Aantal++;
                var u = spel.KaartStack.Pop();
                Hand.Add(u);
                Aantal++;
                Console.WriteLine("Je hebt een " + spel.DeckSpeler[spel.DeckSpeler.Count - 1] + " en een " + spel.DeckSpeler[spel.DeckSpeler.Count - 2] + " gekregen.");
                int TotaalWaarde = WaardeBepalen(0);
                Console.WriteLine("Het totaal van je kaarten is " + TotaalWaarde);
            }
            else
            {
                var z = spel.KaartStack.Pop();
                spel.DeckSpeler.Add(z);
                Aantal++;
                Console.WriteLine("Je hebt een " + spel.DeckSpeler[spel.DeckSpeler.Count - 1] + " gekregen.");
                int TotaalWaarde = WaardeBepalen(0);
                Console.WriteLine("Het totaal van je kaarten is " + TotaalWaarde + ".");
            }
        }


        static public int WaardeBepalen(int totalewaarde)
        {
            for (int i = 0; i < Aantal; i++)
            {
                int x = spel.DeckSpeler[i].Waarde;
                totalewaarde = totalewaarde + x;
            }
            return totalewaarde;
        }
    }
}
