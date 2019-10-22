using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class KaartenDatabase //13 kaarten aanmaken in een array, lijst maken voor complete deck
    {
        static int Ace = 11;
        static int Jack = 10;
        static int Queen = 10;
        static int King = 10;
        
        static public List<KaartenDeck> KaartenDeckMaken = new List<KaartenDeck>();

        public static void KaartTerug()
        {
            for (int i = 0; i < Nummer.Length; i++)
            {
                for (int x = 0; x < Kleur.Length; x++)
                {
                    KaartenDeckMaken.Add(new KaartenDeck(Nummer[i], Kleur[x]));
                }
            }
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(KaartenDeckMaken[i]);
            }

        }
    }
}
