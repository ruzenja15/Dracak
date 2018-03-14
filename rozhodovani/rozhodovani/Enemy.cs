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
            this.type = type;
            this.image = "img/"+image+".png";
            name = "kokot";
            DMG = level * 3.5f;
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
                    return level * 13.5f;
                case Type.BOSS:
                    return level * 17;
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
