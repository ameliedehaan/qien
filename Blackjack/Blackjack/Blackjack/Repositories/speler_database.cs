using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Repositories
{
    public class speler_database
    {
        private spelEntities context = new spelEntities();

        public IEnumerable<speler> GetNames()
        {
            return context.spelers.AsEnumerable();
        }

        public IEnumerable<plek_> GetGameTimes()
        {
            return context.plek_.AsEnumerable();
        }

        public speler GetNaambyname(string name)
        {
            return context.spelers.First(s => s.naam == name);

        }

        int spelerID = 0;
        public void NaamCheck(string name)
        {
            bool exists = false;
            foreach (speler speler in GetNames())
            {
                if (name == speler.naam)
                {
                    exists = true;
                    Console.WriteLine("Welkom terug");
                    int spelerID = speler.speler_id;
                    Console.WriteLine(spelerID);
                    Console.ReadLine();
                    
                }
            }
            if (exists == false)
            {
                var newPlayer = new speler();
                newPlayer.naam = name;
                AddUser(newPlayer);
                int spelerID =  newPlayer.speler_id;
                Console.WriteLine(spelerID);
            }
        }
        public void AddUser(speler player)
        {
            context.spelers.Add(player);
            context.SaveChanges();
        }

        public void AddPlek(plek_ plek) { 
            context.plek_.Add(plek);
        }

        int plekCurrent = 0;
        public void FindPlek(speler userName)
        {

            int CurrentPlayID = userName.plek_id;
            int userName.speler_id = int CurrentPlayID;
            bool Begonnen = false;
            //plekspeler = plek.speler_id;
            foreach (plek_ plek in GetGameTimes())
            {
                if (plek.spel_id == 2)
                {
                    if (plek.plek_id > 0)
                    {
                        Begonnen = true;
                        var y = Convert.ToInt32(plek.plek);
                      // plekCurrent = x;
                        Console.WriteLine("Je hebt al " + y + "keer van de dealer gewonnen.");
                    }
                    if (Begonnen == false)
                    {
                        AddPlek(plek);
                        Console.WriteLine("Dit is de eerste keer dat je dit spel speelt!");
                    }
                }
            }


        }
    }
    }

