using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace rozhodovani
{
    public class EnergyCommand : ICommand
    { 

        public event EventHandler CanExecuteChanged;

        private CombatViewModel data;
        private float manacost;

        public EnergyCommand(CombatViewModel combat)
        {
            data = combat;
            manacost = data.Playermana * 0.30f;

        }


        public bool CanExecute(object parameter)
        {

            return true;
        }

        public void Execute(object parameter)
        {

            if (data.Playermana < manacost)
            {

            }
            else
            {
                data.Enemyhealth -= data.Playerint;
                data.Playermana -= manacost;
                EnemyControler.Attack(data);
            }



        }
    }
}
