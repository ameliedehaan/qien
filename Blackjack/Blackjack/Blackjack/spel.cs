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
        public Stack<Kaart> KaartStack = new Stack<Kaart>();
        private readonly string[] kleuren = new string[] { "Harten", "Schoppen", "Ruiten", "Klaver" };
        string userInput = "";
        bool playActive = true;

        public spel()
        {
            Console.WriteLine("Welkom bij Blackjack");

            DeckOpbouwen();
            Kaarten.Randomize();
            StackBouwen(); // stack is opgebouwd en werkt.
            Spacer();
            Console.WriteLine("We gaan spelen, druk op k om een kaart te krijgen.");

            while (playActive == true) {
                userInput = Console.ReadLine();
                if (userInput == "k")
                {
                    SpelerDeckBouwen();
                    Spacer();

                }
                else
                {
                    Spacer();
                    Console.WriteLine("Je hebt de verkeerde toets ingetypd. Typ k om een kaart te krijgen.");
                    userInput = Console.ReadLine();
                }
            }
        }

        public void DeckOpbouwen()
        {
            foreach (var kleur in kleuren)
            {
                for (int i = 2; i < 11; i++)
                {
                    Kaarten.Add(new Kaart(i, kleur));
                }
                Kaarten.Add(new PlaatjesKaart(kleur, "Boer"));
                Kaarten.Add(new PlaatjesKaart(kleur, "Koningin"));
                Kaarten.Add(new PlaatjesKaart(kleur, "Koning"));
                Kaarten.Add(new Aas(kleur, "Aas"));
            }
        }

        public void StackBouwen()
        {
            for (int i = 0; i < 52; i++)
            {
                var w = spel.Kaarten[i];
                KaartStack.Push(w);
            }
        }

        public void SpelerDeckBouwen()
        {
            var z = KaartStack.Pop();
            DeckSpeler.Add(z);
            Console.WriteLine("Je hebt een " + DeckSpeler[DeckSpeler.Count -1] + " gekregen.");


        }
        public void PuntenTelling()
        {
            DeckSpeler.Naam 
        }
        public void Spacer()
        {
            Console.WriteLine("===================================================");
        }
    }
}




