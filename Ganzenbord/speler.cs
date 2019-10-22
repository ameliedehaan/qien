using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefenen2
{
    public class Player
    {
        private string name;
        private int plek;
        private int gegooid;
        private bool status;
        private int beurten;            //aantal beurten overslaan
        private bool put;
        public Player(string speler)
    {
        name = speler;
        plek = 0;
        beurten = 0;
        gegooid = 0;
        }

        public string Name { get { return name; } set { }}
        public int Plek { get { return plek; } set { plek = value; } }
        public int Gegooid { get { return gegooid; } set { gegooid = value; } }
        public bool Status { get { return status; } set { status = value; } }
        public int Beurten { get { return beurten; } set { beurten = value; } }
        public bool Put { get { return put; } set { put = value; } }



        public void gooien()
        {
            Gegooid = dobbelSteen.dobbellen();
        }
    }
    }

