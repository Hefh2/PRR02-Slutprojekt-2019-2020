using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRR02_Slutprojekt_2019_2020
{
    class CultEvents : CultInfo
    {



        public override void Event()
        {
            int eventNum = generator.Next(1, 4);

            if (eventNum == 1)
            {
                bool loop = true;
                while (loop == true)
                {
                    CultStats();
                    //Writes out the event and asks the player to answer 1 or 2.
                    Console.WriteLine("\nCorona is spreading among the cult" +
                        "\n\n1. Pay people to stay home from work in order to make the disease spread at a rate doctor can handle." +
                        "\n2. Let the disease spread freely and die out on it's own.");

                    string answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        //If the player has enough treasure for this option it will proceed and say what happens, as well as reduce the treasure, otherwise it will ask for a different answer and repeat the loop.
                        if (treasure > 99)
                        {
                            treasure -= 100;
                            happiness += 50;
                            loop = false;
                            Console.WriteLine("\nYou paid the cult members with 100 gold from the treasury to maky many of them stay home, which allowed the disease to be treated effectively." +
                                "\nThe cult members are happy with you actions.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("\nYou don't have enough treasure for this option.");
                            Console.ReadLine();
                        }
                    }
                    else if (answer == "2")
                    {
                        //This option can be chosen no matter what, although it can kill you if population goes under 1.
                        population -= 10;
                        loop = false;
                        Console.WriteLine("\nYou allowed the disease to spread freely, which killed 10 members of the cult.");
                        Console.ReadLine();
                    }
                    else
                    {
                        //If the player doesn't answer properly it tells them to answer properly and repeats the loop.
                        Console.WriteLine("\nAnswer \"1\" or \"2\" please.");
                        Console.ReadLine();
                    }

                }
            }

            else if (eventNum == 2)
            {
                bool loop = true;
                while (loop == true)
                {
                    CultStats();
                    Console.WriteLine("A few mercenaries from a local lord is investigating your cult out of suspicion." +
                        "\n\n1. Bribe the mercenaries to ignore any problems." +
                        "\n2. Fight them off with your cult members.");

                    string answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        //If the player has enough treasure for this option it will proceed and say what happens, as well as reduce the treasure, otherwise it will ask for a different answer and repeat the loop.
                        if (treasure > 49)
                        {
                            treasure -= 50;
                            happiness -= 30;
                            loop = false;
                            Console.WriteLine("\nYou bribed the mercenaries with 50 gold out of your treasury and they left without a problem." +
                                "\nThe cult members are calling you a coward.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("\nYou don't have enough treasure for this option.");
                            Console.ReadLine();
                        }
                    }
                    else if (answer == "2")
                    {
                        //This option can be chosen no matter what, although it can kill you if population goes under 1.
                        population -= 10;
                        loop = false;
                        Console.WriteLine("\nYou fought off the mercenaries, the battle resulted in the death of 5 members of the cult.");
                        Console.ReadLine();
                    }
                    else
                    {
                        //If the player doesn't answer properly it tells them to answer properly and repeats the loop.
                        Console.WriteLine("\nAnswer \"1\" or \"2\" please.");
                        Console.ReadLine();
                    }
                }
            }

            else if (eventNum == 3)
            {
                bool loop = true;
                while (loop == true)
                {
                    CultStats();
                    Console.WriteLine("Your cults farmers have had a good harvest this time." +
                        "\n\n1. Save the extra harvest for the future." +
                        "\n2. Sell the extra harvest for gold.");
                    string answer = Console.ReadLine();

                    if (answer == "1")
                    {
                        //Adds 200 to your harvest and stops the loop.
                        harvest += 200;
                        loop = false;
                        Console.WriteLine("\nYou save the extra harvest adding 200 units of food to your storage.");
                    }
                    else if (answer == "2")
                    {
                        harvest += 100;
                        treasure += 100;
                        loop = false;
                        Console.WriteLine("\nYou sell half the harvest adding 100 units of food to your storage and 100 gold to your treasury.");
                        Console.ReadLine();
                    }
                    else
                    {
                        //If the player doesn't answer properly it tells them to answer properly and repeats the loop.
                        Console.WriteLine("\nAnswer \"1\" or \"2\" please.");
                        Console.ReadLine();
                    }
                }
            }
        }


    }
}
