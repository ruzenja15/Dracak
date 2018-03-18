using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rozhodovani
{
   public class Enemy : Stats
    {


        public Enemy.Type type;
        public Enemy(int level, string image, Enemy.Type type)
        {
            float dmg = level * 3.5f;


            this.type = type;
            this.image = "img/"+image+".png";
            name = "kokot";
            DMG = new Random().Next((int)dmg -2, (int)dmg +4);
            INT = level * 3.5f;
            maxhealth = getenemyhealth(level);
            health = maxhealth;
            maxmana = level * 5;
            mana = maxmana;

        }

        private float getenemyhealth(int level)
        {
            switch (type)
            {
                case Type.BASIC:
                    return level * 17;
                case Type.BOSS:
                    return level * 20;
                default:
                    return 0;

            }
        }

        public enum Type
        {
            BASIC, BOSS
        }
    }
}
