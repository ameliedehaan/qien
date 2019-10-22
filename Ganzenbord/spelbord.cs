using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefenen2
{
    public class Spelbord

    {
        public static bool Spelen = true;

        public static void Vak(List<Player> spelersAll, Player activePlayer)
        { 
           string y = "";
            activePlayer.Plek = activePlayer.Plek + activePlayer.Gegooid;
            if (activePlayer.Put == false)
            {
                switch (activePlayer.Plek)
                {
                    case 23:
                        y = "Je hebt een " + activePlayer.Gegooid + " gegooid. Je staat op plek 23, en zit in de gevangenis. Je hebt het spel verloren. Typ n om weer opnieuw te beginnen.";
                        Console.WriteLine(y);
                        activePlayer.Plek = 0;
                        break;
                    case 25:
                    case 45:
                        y = "Je hebt " + activePlayer.Gegooid + " gegooid. Je bent op plek " + (activePlayer.Plek) + " beland. Je gaat terug naar start.";
                        Console.WriteLine(y);
                        activePlayer.Plek = 0;
                        break;
                    case 31:
                        Console.WriteLine(activePlayer.Name + " zit in de put");
                        foreach (Player speler in spelersAll)
                        {
                            if (speler.Put)
                            {
                                speler.Put = false;
                                Console.WriteLine(speler.Name + " is uit de put");
                            }
                        }
                        activePlayer.Put = true;
                        break;
                    case 10:
                    case 20:
                    case 30:
                    case 40:
                    case 50:
                    case 60:
                        y = "Je hebt " + activePlayer.Gegooid + " gegooid. Je bent op plek " + (activePlayer.Plek) + ". Bonus stapjes! Je staat op plek " + (activePlayer.Plek + activePlayer.Gegooid) + ".";
                        activePlayer.Plek = activePlayer.Plek + activePlayer.Gegooid;
                        Console.WriteLine(y);
                        break;
                    case 63:
                        y = "Je staat op 63! Je hebt gewonnen! " + activePlayer + " heeft gewonnen!";
                        Console.WriteLine(y);
                        Spelen = false;
                        break;
                    case 64:
                    case 65:
                    case 66:
                    case 67:
                    case 68:
                        activePlayer.Plek = 63 - (activePlayer.Plek - 63);
                        y = "Je hebt " + activePlayer.Gegooid + " gegooid. Je hebt te veel gegooid en gaat weer achteruit. Je staat nu op plek " + activePlayer.Plek + ".";
                        Console.WriteLine(y);
                        break;
                    default:
                        y = "Je hebt " + activePlayer.Gegooid + " gegooid. Je staat op plek " + (activePlayer.Plek);
                        Console.WriteLine(y);
                        break;

                }
            }
            else
            {
                Console.WriteLine("Je zit in de put! Je moet deze beurt overslaan!");
                activePlayer.Put = false;
            }
        }
    }
}