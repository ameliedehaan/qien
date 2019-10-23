using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Kaart
    {
        public int Nummer { get; set; }
        public string Kleur { get; set; }
        public bool Gepakt { get; set; }

        public Kaart(int nummer, string kleur)
        {
            this.Nummer = nummer;
            this.Kleur = kleur;
            this.Gepakt = false;
        }

        public override string ToString()
        {
            return $"{Nummer} {Kleur}";
        }
    }

    public class PlaatjesKaart : Kaart
    {
        public PlaatjesKaart(string kleur, string naam) : base(10, kleur)
        {
            Naam = naam;
        }
        public string Naam { get; set; }

        public override string ToString()
        {
            return $"{Naam} {Kleur}";
        }

    }
        public class Aas : Kaart
        {
            public Aas(string kleur, string naam): base(11, kleur)
            {
                Naam = naam;
            }
        public string Naam { get; set; }
            public override string ToString()
            {
                return $"{Naam} {Kleur}";
            }

        }
}
