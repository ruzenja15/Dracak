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

        private float basedef;


        public DefendCommand(CombatViewModel combat)
        {
            data = combat;
            basedef = data.Playerdef;

        }


        public bool CanExecute(object parameter)
        {

            return true;
        }

        public void Execute(object parameter)
        {
            data.Playerdef += basedef * 0.6f;
            EnemyControler.Attack(data);
            data.Playerdef = basedef;


        }
    }
}
