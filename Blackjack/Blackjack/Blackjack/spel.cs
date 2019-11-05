using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackExtension;

namespace Blackjack
{
    public class spel
    {
        static public List<Kaart> Kaarten = new List<Kaart>();
        static public List<Kaart> DeckSpeler = new List<Kaart>();
        static public List<Player> Spelers = new List<Player>();
        public Player activePlayer;
        static public List<Kaart> Dealer = new List<Kaart>();
        static public Stack<Kaart> KaartStack = new Stack<Kaart>();
        private readonly string[] kleuren = new string[] { "Harten", "Schoppen", "Ruiten", "Klaver" };
        static public string userInput = "";
        static public bool playActive = true;
        static public bool FirstPull = true;

        public spel()
        {
            DeckOpbouwen();
            Kaarten.Randomize();
            Stack.StackBouwen(); // stack is opgebouwd en werkt.

            //welkomst berichten en namen spelers
            Console.WriteLine("Welkom bij Blackjack!");
            Console.WriteLine("Wat is je naam Speler 1?");
            addPlayer(Console.ReadLine());
            activePlayer = Spelers[0];
            Console.WriteLine("Wat is je naam Speler 2?");
            addPlayer(Console.ReadLine());
            Spacer.spacer();

            while (playActive == true)
            {
                foreach (Player activePlayer in Spelers) //spelers selecteren
                if (activePlayer.TotaalWaarde == 0) //begin bericht voor elke speler
                {
                    Console.WriteLine("We gaan spelen, druk op k om een kaart te krijgen.");
                }
                userInput = Console.ReadLine();
                if (userInput == "k") //een kaart trekken
                {
                    Player.SpelerDeckBouwen();
                    //Player.Hand = spel.DeckSpeler;
                    //var x = DeckPlayer.TotaalWaarde;
                    //activePlayer.TotaalWaarde = x;
                    Spacer.spacer();
                    if (FirstPull == true && playActive == true)
                    {
                        DeckDealer.DealerDeckBouwen();
                        PuntenRegels.puntenTelling();
                    }
                    Spacer.spacer();
                    PuntenRegels.puntenTelling();
                    if (playActive == true)
                    {
                        Console.WriteLine("Neem nog een kaart met k, druk op p voor een pas of q om het spel te beeindigen.");
                        FirstPull = false;
                    }
                }

                else if (userInput == "p" && FirstPull == false)
                {
                    Spacer.spacer();
                    activePlayer.TotaalWaarde = DeckPlayer.WaardeBepalen(0);
                    Console.WriteLine("De kaarten in je hand zijn:");
                    string HandKaarten = "";
                    int x = DeckSpeler.Count; //hoeveelheid kaarten in hand
                    for (int i = 0; i < x; i++)
                    {
                        HandKaarten = HandKaarten + DeckSpeler[i] + " ";
                    }
                    //laten zien hoeveel kaarten je hebt en de totaalwaarde.
                    Console.WriteLine(HandKaarten);
                    Console.WriteLine("De totaalwaarde van je kaarten is " + activePlayer.TotaalWaarde + ".");
                    activePlayer.pas = true;
                    var y = Spelers.Count;

                    PuntenRegels.puntenTelling(); //puntentelling voor de beurt van de dealer.

                }
                else if (userInput == "q") //stoppen met het spel
                {
                    playActive = false;
                    Console.WriteLine("Het spel is gestopt.");
                }
                else //verkeerde toets getypd.
                {
                    Spacer.spacer();
                    Console.WriteLine("Je hebt de verkeerde toets ingetypd. Typ k om een kaart te krijgen of q om het spel te beeindigen.");
                    userInput = Console.ReadLine();
                }
            }
            while (playActive == false)
                {
                    Console.WriteLine("Wil je nog een keer spelen? Druk dan op toets n.");
                    if (userInput == "n")
                    {
                        playActive = true;
                    }
                }
                Console.ReadLine();
            
        }

        public void DeckOpbouwen() //deck opbouwen 1x per spel.
        {
            foreach (var kleur in kleuren)
            {
                for (int i = 2; i < 11; i++)
                {
                    Kaarten.Add(new Kaart(i, kleur, i));
                }
                Kaarten.Add(new PlaatjesKaart(kleur, "Boer"));
                Kaarten.Add(new PlaatjesKaart(kleur, "Koningin"));
                Kaarten.Add(new PlaatjesKaart(kleur, "Koning"));
                Kaarten.Add(new Aas(kleur, "Aas"));
            }
        }
        public void addPlayer(string Naam)
        {
            Player spelerNaam = new Player(Naam);
            Spelers.Add(spelerNaam);
        }
    }
}




