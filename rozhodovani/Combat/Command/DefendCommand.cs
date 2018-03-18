using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace rozhodovani
{
    public class DefendCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private CombatViewModel data;

        //private float basedef;
        private float defense;
        private float EnemyDamage;
        private float ManaUp;


        public DefendCommand(CombatViewModel combat)
        {


            data = combat;
            defense = data.Enemydmg * 0.2f;
            EnemyDamage = data.Enemydmg;
            ManaUp = data.Playermana * 0.10f;
            //  basedef = data.Playerdef;

        }


        public bool CanExecute(object parameter)
        {

            return true;
        }

        public void Execute(object parameter)
        {

            data.Enemydmg = defense;
            data.Playermana += ManaUp;

                if(data.Playermana >= data.Playermaxmana)
            {
                data.Playermana = data.Playermaxmana;

            }


            //data.Playerdef += basedef * 0.6f;
            EnemyControler.Attack(data);
            data.Enemydmg = EnemyDamage;
            //data.Playerdef = basedef;


        }
    }
}
