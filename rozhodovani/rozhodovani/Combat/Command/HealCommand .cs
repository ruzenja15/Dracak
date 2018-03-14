using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace rozhodovani
{
    public class HealCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private CombatViewModel data;

        private float heal;
        private float manacost;

        public HealCommand(CombatViewModel combat)
        {
            data = combat;
            heal = data.Playerhealth * 0.5f;
            manacost = data.Playermana * 0.40f;


        }


        public bool CanExecute(object parameter)
        {
            
            return true;
        }

        public void Execute(object parameter)
        {

            data.Playerhealth += heal;
            if (data.Playerhealth > data.Playermaxhealth)
                data.Playerhealth = data.Playermaxhealth;
            data.Playermana -= manacost;
            EnemyControler.Attack(data);


        }
    }
}
