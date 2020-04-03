using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRR02_Slutprojekt_2019_2020
{
    abstract class CultInfo
    {
        public string cultName;
        public int treasure;
        public int harvest;
        public int population;
        public int happiness;
        string happinessRating;
        public static Random generator = new Random();

        public CultInfo()
        {
            treasure = generator.Next(200, 601);
            harvest = generator.Next(200, 601);
            happiness = generator.Next(200, 601);
            population = generator.Next(20, 61);

        }

        public void CultStats()
        {
            //Clears console and writes out your information
            Console.Clear();
            if (happiness < 201)
            {
                happinessRating = "Low";
            } else if (happiness < 401)
            {
                happinessRating = "Medium";
            } else
            {
                happinessRating = "High";
            }
            Console.WriteLine(
                "\nCult name: " + cultName +
                "\n\nTreasure: " + treasure +
                "\nHarvest: " + harvest +
                "\nPopulation: " + population +
                "\nHappiness: " + happinessRating
                );
        }

        public abstract void Event();
    }
}
