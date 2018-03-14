using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace rozhodovani
{
    class NextTextCommand : ICommand
    {

        public event EventHandler CanExecuteChanged;

        private StoryViewModel model;
      

        public NextTextCommand(StoryViewModel model)
        {
            this.model = model;




        }


        public bool CanExecute(object parameter)
        {

            return true;
        }

        public void Execute(object parameter)
        {

            model.index++;

            if (model.index >= model.currentdialog.texty.Count -1)
            {
                model.Enabled = false;
                model.Visibility = Visibility.Visible;
            }
            
            
                model.Text = model.currentdialog.texty[model.index];

            


        }


    }
}
