using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class PuntenRegels
    {
 
        static public void puntenTelling()
        {
            int TotaalWaarde = DeckPlayer.WaardeBepalen(0);
            if (TotaalWaarde > 21)
            {
                Spacer.spacer();
                Console.WriteLine("=================== GAMEOVER ====================== ");
                Spacer.spacer();
                spel.playActive = false;
            }
            else
            { }
        }
    }
}
