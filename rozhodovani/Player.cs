using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rozhodovani
{
    public class Player : Stats
    {
        public Player(int newlevel)
        {
            image = "img/Frankie.png";
            level = newlevel;
            name = "Frankie";
            DMG = level * 5;
            INT = level * 7;
            maxhealth = level * 15; 
            health = maxhealth;
            maxmana = level * 10;
            mana = maxmana;
            DEF = 25;

        }

    }
}
