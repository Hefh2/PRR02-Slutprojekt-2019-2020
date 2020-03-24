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
                Console.Clear();
                Console.WriteLine(
                    "\nCult name: " + C.cultName +
                    "\n\nTreasure: " + C.treasure +
                    "\nHarvest: " + C.harvest +
                    "\nPopulation: " + C.population +
                    "\nHappiness: " + C.happiness
                    );



                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
