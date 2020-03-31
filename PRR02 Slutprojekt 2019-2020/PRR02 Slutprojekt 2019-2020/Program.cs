using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRR02_Slutprojekt_2019_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            CultInfo C = new CultInfo();
            int eventsCleared = -1;

            //Loop för att välja namn för sin sekt och ser till att den är mellan 10 och 3 bokstäver lång.
            bool loop1 = true;
            while (loop1 == true)
            {
                Console.Clear();
                Console.WriteLine("You wake up and find your father has died and it's time for you to take over as the leader of hit cult." +
                "\nWhat do you want to name your cult? Your name can only be 3 - 10 letters long.");
                C.cultName = Console.ReadLine();

                if (C.cultName.Length < 11 && C.cultName.Length > 2)
                {
                    loop1 = false;
                }
            }
            Console.WriteLine("\nYou have decided to rename your fathers cult to " + C.cultName + ".");
            Console.WriteLine("\nAs the game goes on different events will happen and these will allow you to balance your cults resources, " +
                "following is an explanation of the different resources." +
                "\nTreasure: Limits your choices during events." +
                "\nHarvest: When harvest reaches 0 your population and happiness will start decreasing." +
                "\nPopulation: When population reaches 0 you lose." +
                "\nThe higher your population is the more treasure you receive each turn." +
                "\nHappiness: When happiness reaches 0 you lose." +
                "\nIf your happiness is under a certain level your population will decrease each turn.");
            Console.WriteLine("\nPress any button to continue.");
            Console.ReadKey();

            bool loop2 = true;
            while (loop2 == true)
            {
                //Ticks the event counter up by 1
                eventsCleared++;
                //Makes sure population and happiness doesn't go under 0
                if (C.population < 0)
                {
                    C.population = 0;
                }
                if (C.happiness < 0)
                {
                    C.happiness = 0;
                }
                //Changes treasure and harvest according to your population
                C.treasure += C.population;
                C.harvest -= C.population;
                //Makes sure harvest doesn't go under 0
                if (C.harvest < 0)
                {
                    C.harvest = 0;
                }
                //Clears console and writes out your information
                Console.Clear();
                Console.WriteLine(
                    "\nCult name: " + C.cultName +
                    "\n\nTreasure: " + C.treasure +
                    "\nHarvest: " + C.harvest +
                    "\nPopulation: " + C.population +
                    "\nHappiness: " + C.happiness
                    );

                
                //Heres where the event is written


                //Checks your stats if you lost and if some stats will decrease due to a lack in other stats.
                if (C.happiness < 1 || C.population < 1)
                {
                    loop2 = false;
                }
                if (C.harvest < 1)
                {
                    C.population -= 5 + C.population / 10;
                    C.happiness -= 20 + C.happiness / 10;
                }
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("You survived through " + eventsCleared + " events!");

            Console.ReadKey();
        }
    }
}
