using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace rozhodovani
{
    /// <summary>
    /// Interakční logika pro Combat.xaml
    /// </summary>
    public partial class Combat : Page
    {

        public delegate void OnBattleEnd(int id);
        public static event OnBattleEnd OnBattleEndEvent;
        Dialog dialog;
        Combat_controler controler;

        CombatViewModel model;

        public Combat(Dialog dialog)  
        {

            InitializeComponent();
            this.dialog = dialog;
            this.controler = dialog.Combat;
            model = new CombatViewModel(controler.hrac, controler.enemy);

            OnBattleEndEvent += EndCombat;

            this.DataContext = model;


        }

        private void EndCombat(int id)
        {

           controler.hrac.level++;
           NavigationService.Navigate(new Pribeh(dialog.moznost[id].dialog, controler.hrac.level));
        }
    }
}
