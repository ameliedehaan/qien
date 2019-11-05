using Blackjack.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Blackjack
{
    public class Program
    {
        public static void Main(string[] args)
        {

            speler_database d = new speler_database();
            Console.WriteLine("Wat is je naam speler?");
            var userName = Console.ReadLine();
             d.NaamCheck(userName);
            d.FindPlek(userName);
            // nieuwe speler gecreerd of user gevonden. Nu oproepen plek (oft. hoeveelheid gewonnen.)
          //  Console.WriteLine("Je hebt al " +  " keer van de dealer gewonnen.");

            Console.WriteLine("Welkom " + userName);
            Console.ReadLine();
            spel _spel = new spel();
        }
    }
}
