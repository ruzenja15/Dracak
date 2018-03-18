using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace rozhodovani
{
   public class CombatViewModel : AViewModel
    {
        public CombatViewModel(Player player, Enemy enemy)
        {


            Playermaxhealth = player.maxhealth;
            Playerhealth = player.health;
            Playermaxmana = player.maxmana;
            Playermana = player.mana;
            Playerimage = player.image;
            Playername = player.name;
            Playerdmg = player.DMG;
           // Playerdef = player.DEF;
            Playerint = player.INT;

            Enemymaxhealth = enemy.maxhealth;
            Enemyhealth = enemy.health;
            Enemyimage = enemy.image;
            Enemyname = enemy.name;
            Enemydmg = enemy.DMG;


            Physical = new PhysicalCommand(this);
            Energy = new EnergyCommand(this);
            Defend = new DefendCommand(this);
            Heal = new HealCommand(this);

            ResultVisibility = Visibility.Hidden;


        }



        private PhysicalCommand physical;
        public PhysicalCommand Physical
        {
            get { return physical; }
            set
            {
                if (physical != value)
                {
                    physical = value;
                    OnPropertyChanged("Physical");
                }
            }
        }

        private EnergyCommand energy;
        public EnergyCommand Energy
        {
            get { return energy; }
            set
            {
                if (energy != value)
                {
                    energy = value;
                    OnPropertyChanged("Energy");
                }
            }
        }

        private DefendCommand defend;
        public DefendCommand Defend
        {
            get { return defend; }
            set
            {
                if (defend != value)
                {
                    defend = value;
                    OnPropertyChanged("Defend");
                }
            }
        }

        private HealCommand heal;
        public HealCommand Heal
        {
            get { return heal; }
            set
            {
                if (heal != value)
                {
                    heal = value;
                    OnPropertyChanged("Heal");
                }
            }
        }


        



        private float playermaxhealth;
        public float Playermaxhealth
        {
            get { return playermaxhealth; }
            set
            {
                if (playermaxhealth != value)
                {
                    playermaxhealth = value;
                    OnPropertyChanged("Playermaxhealth");
                }
            }
        }
        public bool jeMrtvejhrac = false;

        private float playerhealth;
        public float Playerhealth
        {
            get { return playerhealth; }
            set
            {
                if (playerhealth != value)
                {            
                    playerhealth = value;
                    if (playerhealth <= 0)
                    {
                        SetCombatResult(1, "Prohrál jsi","Red");
                    }

                    OnPropertyChanged("Playerhealth");

                }
            }
        }


        private float playermaxmana;
        public float Playermaxmana
        {
            get { return playermaxmana; }
            set
            {
                if (playermaxmana != value)
                {
                    playermaxmana = value;
                    OnPropertyChanged("Playermaxmana");
                }
            }
        }

        private float playermana;
        public float Playermana
        {
            get { return playermana; }
            set
            {
                if (playermana != value)
                {
                    playermana = value;
                    OnPropertyChanged("Playermana");
                }
            }
        }


        private string playerimage;
        public string Playerimage
        {
            get { return playerimage; }
            set
            {
                if (playerimage != value)
                {
                    playerimage = value;
                    OnPropertyChanged("Playerimage");
                }
            }
        }

        private string playername;
        public string Playername
        {
            get { return playername; }
            set
            {
                if (playername != value)
                {
                    playername = value;
                    OnPropertyChanged("Playername");
                }
            }
        }


        /*private float playerdef;
        public float Playerdef
        {
            get { return playerdef; }
            set
            {
                if (playerdef != value)
                {
                    playerdef = value;
                    OnPropertyChanged("Playerdef");
                }
            }
        }*/

        private float playerdmg;
        public float Playerdmg
        {
            get { return playerdmg; }
            set
            {
                if (playerdmg != value)
                {
                    playerdmg = value;
                    OnPropertyChanged("Playerdmg");
                }
            }
        }


        private float playerint;
        public float Playerint
        {
            get { return playerint; }
            set
            {
                if (playerint != value)
                {
                    playerint = value;
                    OnPropertyChanged("Playerint");
                }
            }
        }


        //ENEMY
        public bool jeMrtvejenemy = false;

        private float enemymaxhealth;
        public float Enemymaxhealth
        {
            get { return enemymaxhealth; }
            set
            {
                if (enemymaxhealth != value)
                {
                    enemymaxhealth = value;
                    OnPropertyChanged("Enemymaxhealth");
                }
            }
        }


        private float enemyhealth;
        public float Enemyhealth
        {

            get { return enemyhealth; }
            set
            {
                if (enemyhealth != value)
                {
                    enemyhealth = value;
                    if(enemyhealth <= 0)
                    {
                        SetCombatResult(0, "Vyhrál jsi", "Green", "Zvýšil se ti level (+1)");
                    }

                    OnPropertyChanged("Enemyhealth");
                }
            }
        }


        private string enemyimage;
        public string Enemyimage
        {
            get { return enemyimage; }
            set
            {
                if (enemyimage != value)
                {
                    enemyimage = value;
                    OnPropertyChanged("Enemyimage");
                }
            }
        }


        private string enemyname;
        public string Enemyname
        {
            get { return enemyname; }
            set
            {
                if (enemyname != value)
                {
                    enemyname = value;
                    OnPropertyChanged("Enemyname");
                }
            }
        }


        private float enemydmg;
        public float Enemydmg
        {
            get { return enemydmg; }
            set
            {
                if (enemydmg != value)
                {
                    enemydmg = value;
                    OnPropertyChanged("Enemydmg");
                }
            }
        }



        //Pokračovat


        private Visibility resultVisibility;
        public Visibility ResultVisibility
        {
            get { return resultVisibility; }
            set
            {
                if (resultVisibility != value)
                {
                    resultVisibility = value;
                    OnPropertyChanged("ResultVisibility");
                }
            }
        }



        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        private string reward;
        public string Reward
        {
            get { return reward; }
            set
            {
                if (reward != value)
                {
                    reward = value;
                    OnPropertyChanged("Reward");
                }
            }
        }

        private int battleResult;
        public int BattleResult
        {
            get { return battleResult; }
            set
            {
                if (battleResult != value)
                {
                    battleResult = value;
                    OnPropertyChanged("BattleResult");
                }
            }
        }

        private string color;
        public string Color
        {
            get { return color; }
            set
            {
                if (color != value)
                {
                    color = value;
                    OnPropertyChanged("Color");
                }
            }
        }

        void SetCombatResult(int result, string title, string color, string reward = null)
        {
            ResultVisibility = Visibility.Visible;
            Color = color;
            Title = title;
            Reward = reward;
            BattleResult = result;
        }


    }
}
