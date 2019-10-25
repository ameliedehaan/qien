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
            int WaardeDealer = DeckDealer.WaardeBepalen(0);

            if (TotaalWaarde > 21)
            {
                Spacer.spacer();
                Console.WriteLine("Je bent boven de 21 en hebt verloren! De totale waarde van je kaarten is " + TotaalWaarde + ".");
                Spacer.spacer();
                spel.playActive = false;
            }
            else if (spel.userInput == "p")
            {
                Spacer.spacer();
                if (WaardeDealer > 16 && TotaalWaarde > WaardeDealer)
                {
                    Spacer.spacer();
                    Console.WriteLine("=============== Je hebt Gewonnen! =================");
                    Spacer.spacer();
                }
                else if (WaardeDealer > 16 && TotaalWaarde < WaardeDealer)
                {
                    Spacer.spacer();
                    Console.WriteLine("De dealer heeft een hogere totaalwaarde, " + WaardeDealer + ". Je hebt dus verloren!");
                    Spacer.spacer();
                }
                else 
                {
                    while (WaardeDealer < 17)
                    {
                        DeckDealer.DealerDeckBouwen();
                        WaardeDealer = DeckDealer.WaardeBepalen(0);
                    }
                    if (WaardeDealer < 22 && TotaalWaarde > WaardeDealer)
                    {
                        Spacer.spacer();
                        Console.WriteLine("=============== Je hebt Gewonnen! =================");
                        Spacer.spacer();
                    }
                    else if (WaardeDealer <22 && TotaalWaarde < WaardeDealer)
                    {
                        Spacer.spacer();
                        Console.WriteLine("De dealer heeft een hogere totaalwaarde, " + WaardeDealer + ". Je hebt dus verloren!");
                        Spacer.spacer();
                    }
                    else
                    {
                        Spacer.spacer();
                        Console.WriteLine("De dealer zit boven de 21, je hebt gewonnen!");
                        Spacer.spacer();
                    }
                }

            }
            else if (TotaalWaarde == 21)
            {
                Spacer.spacer();
                    Console.WriteLine("=============== Je hebt Gewonnen! =================");
                spel.playActive = false;

            }
        }
    }
}
