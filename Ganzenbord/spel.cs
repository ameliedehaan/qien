using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefenen2
{
    class spel
    {
        public string Start { get; set; }
        public int Beurt { get; set; }
        public int x { get; set; }

        public List<Player> spelersAll = new List<Player>();
        public Player activePlayer;
        public Spelbord bord = new Spelbord();
        public spel()
        {

            Console.WriteLine("Wat is je naam Player 1?");
            addPlayer(Console.ReadLine());
            activePlayer = spelersAll[0];
            Console.WriteLine("Wat is je naam Player 2?");
            addPlayer(Console.ReadLine());
            Console.WriteLine("Welkom! Laten we beginnen.");
            string inputUser = "";


           while (Spelbord.Spelen == true)
            {
                foreach (Player activePlayer in spelersAll) {

                    if (activePlayer.Plek == 0)
                    {
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine(activePlayer.Name + ", je staat op start. Gooi je dobbelsteen met de key g.");
                    }
                  else
                    {
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine(activePlayer.Name + ", je staat op " + activePlayer.Plek + " Gooi je dobbelsteen met de key g.");
                    }
                    inputUser = Console.ReadLine();
                    if (inputUser == "g")
                    {
                        activePlayer.gooien();
                        Regels();
                        volgendeBeurt();
                    }
                    else
                    {
                        Console.WriteLine("Je hebt de verkeerde toets ingetypd. Gebruik key g om de dobbelsteen te gooien.");
                        Console.ReadKey();
                    }
                }
            }
            Console.WriteLine("Het spel is beeindigd. Typ n om een nieuw spel te beginnen.";
            if (inputUser == "n")
            { Spelbord.Spelen = true; }
            else
            {
                Console.WriteLine("Je hebt de verkeerde toets ingetypd. Gebruik key g om de dobbelsteen te gooien.");
                Console.ReadKey();
            }
        }
        public void Regels()
        {
            Spelbord.Vak(spelersAll, activePlayer);
        }
        public void addPlayer(string Naam)
        {
            Player spelerNaam = new Player(Naam);
            spelersAll.Add(spelerNaam);
        }

        public void volgendeBeurt()
        {
            if (activePlayer == spelersAll[spelersAll.Count - 1])
                activePlayer = spelersAll[0];
            else if (activePlayer == spelersAll[0])
            {
                activePlayer = spelersAll[1];
            }

        }
    }
}




