using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace rozhodovani
{
    class NextDialogCommand : ICommand
    {

        public event EventHandler CanExecuteChanged;

        private StoryViewModel model;


        public NextDialogCommand(StoryViewModel model)
        {

            this.model = model;

            /*Button button = (Button)sender;
                        string decision = button.Content.ToString();

                        
                        */


        }


        public bool CanExecute(object parameter)
        {

            return true;
        }

        public void Execute(object parameter)
        {
            int index = int.Parse(parameter.ToString());

            Moznost moznost = model.currentdialog.moznost[index];
            model.currentdialog = moznost.dialog;

            if (model.currentdialog.Combat != null)
            {
                model.UserControlView = new CombatUserControl(model.currentdialog);
               
                return;

            }



            model.Enabled = true;
            model.Visibility = Visibility.Hidden;
            model.index = 0;

            model.Text = model.currentdialog.texty[model.index];

            model.Firstdecision = model.currentdialog.moznost[0].decision;
            model.Seconddecision = model.currentdialog.moznost[1].decision;

        }


    }
}
