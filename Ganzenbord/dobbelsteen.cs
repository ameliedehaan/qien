using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefenen2
{
    public class dobbelSteen
    {
        public static int dobbellen()
        {
            Random randm = new Random();
            int randDobbel = randm.Next(1, 6);
            Convert.ToInt32(randDobbel);
            return randDobbel;
        }
    }
}
