using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rozhodovani
{
    public class Combat_controler
    {
        public bool activate;
        public Player hrac;
        public Enemy enemy;

        public Combat_controler(bool activate, Player hrac, Enemy enemy)
        {
            this.activate = activate;
            this.hrac = hrac;
            this.enemy = enemy;
        }

    }
}
