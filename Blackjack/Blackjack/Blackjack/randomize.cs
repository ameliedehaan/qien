using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackExtension;


namespace BlackjackExtension
{
    public static class RandomizeExtension
    {
        public static void Randomize<T>(this IList<T> list) {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1) {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }        
        }
    }
}



