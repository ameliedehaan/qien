using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefenen2.Vakjes
{
    public class Vakje
    {
        public virtual int ManipuleerPositie(int aantalgegooid) //methode die virtual is kan geoveride worden door een afgeleide klasse.
        {
            return 0; //standaard doet een vakje niks
        }
        
    }
    public class Brug: Vakje // brug krijgt bovenstaande methode
    {
        public override int ManipuleerPositie(int aantalgegooid)
        {
            return aantalgegooid;
        }
    }
}
// dan komt in spelbord een list voor vakjes. ArrayList Vakjes {get; set;}
// Vakjes = new ArrayList{ 
//new Vakje())
// for (int i=0; i < 62; i++        zo maak je 63 vakjes
// voor speciaal vakjes een voor een definieren. 
// Vakjes[12] = new Brug()          12 is een indexer
// };


// Vakjes.Add(new Vakje());
// kan vakje dan niet vinden. Moet toevoegen 
// using Vakjes.Vakjes toevoegen.
// zo kan je voor ieder vakje een nieuwe instantie toevoegen.
// public int SpelregelsToepassen(int huidigePositie)
// { var vakje = Vakje[huidigePositie - 1];
// var manipuleerWaarde = vakje.
// je leidt impliciet van object af. 
// ieder object heeft equals, gethashcode, tostring.
// Standaard voor tostring is de typenaam.
