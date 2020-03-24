using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRR02_Slutprojekt_2019_2020
{
    class CultInfo
    {
        public string cultName;
        public int treasure;
        public int harvest;
        public int happiness;
        public int population;
        public int offerings;
        public static Random generator = new Random();

        public CultInfo()
        {
            treasure = generator.Next(200, 601);
            harvest = generator.Next(200, 601);
            happiness = generator.Next(200, 601);
            population = generator.Next(20, 61);
            offerings = generator.Next();

        }


    }
}
