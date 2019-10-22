using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefenen2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randm = new Random();
            int randNumber = randm.Next(1,30);
            int inputInt = 0;

            int i = 0;

            while (inputInt != randNumber) {
                if (i < 1)
                {
                    Console.WriteLine("Guess what number I'm thinking of between 1 and 30");
                    i++;
                }

                else
                { Console.WriteLine("Try again!"); }

                    inputInt = Convert.ToInt32(Console.ReadLine());

                    if (inputInt < randNumber)
                    {
                    Console.WriteLine("You guessed too low!");
                    }
                    else if (inputInt > randNumber)
                    {
                        Console.WriteLine("You guessed too high!");
                    }
                    else
                    {
                        Console.WriteLine("You guessed right!");
                    }
                }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
