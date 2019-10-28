using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegends
{
    
    class Champions 
    {
        public string name;
        public string description;
        public string lane;
        private int age;
    }

    class TopLaner : Champions
    {
        public bool isTop = true;
    }
    class Jungler : Champions 
    {
        public bool isJungle = true;
    }

    class MidLaner : Champions
    {
        public bool isMid = true;
    }

    class Adc : Champions
    {
        public bool isAdc = true;
    }

    class Support : Champions
    {
        public bool isSupport = true;
    }
}

namespace LeagueChampions 
{
    using LeagueOfLegends;

    class FavouriteChamps 
    {
        static void Main(string[] args)
        {
            TopLaner malphite = new TopLaner();
            Jungler warwick = new Jungler();
            MidLaner ahri = new MidLaner();
            Adc varus = new Adc();
            Support nautilus = new Support();

            Console.ReadLine();
        }
    }
}
