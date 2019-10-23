using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Stack
    {
        public Stack<Kaart> KaartStack = new Stack<Kaart>();
        public void StackBouwen()
        {
            for (int i = 0; i < 52; i++)
            {
                var w = spel.Kaarten[i];
                KaartStack.Push(w);
            }
        }
    }

}
