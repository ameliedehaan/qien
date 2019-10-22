using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class spel
    {

        public List<Kaart> Kaarten { get; private set; }
        private string[] kleuren = new string[] { "Harten", "Schoppen", "Ruiten", "Klaver" };


        public spel()
        {
            Console.WriteLine("Welkom bij Blackjack");

            KaartenDatabase.KaartTerug();

            Console.ReadLine();
        }

        public DeckOpbouwen()
        {
            foreach (var kleur in kleuren)
            {
                for (int i = 2; i < 11; i++)
                {
                    Kaarten.Add(new Kaart(i, kleur));
                }
                Kaarten.Add(new PlaatjesKaart(kleur, "Boer"));
            }
        }
        }

    }

