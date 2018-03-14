using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace rozhodovani
{
    public class PhysicalCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private CombatViewModel data;

        public PhysicalCommand(CombatViewModel combat)
        {
            data = combat;

        }
        

        public bool CanExecute(object parameter)
        {
            
            return true;
        }

        public void Execute(object parameter)
        {

            data.Enemyhealth -= data.Playerdmg;
            EnemyControler.Attack(data);
            
        }
    }
}
