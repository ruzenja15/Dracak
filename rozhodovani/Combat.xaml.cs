﻿using System;
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


        Dialog dialog;
        Combat_controler controler;
        CombatViewModel model;

        

        public Combat(Dialog dialog)  
        {

            InitializeComponent();
            this.dialog = dialog;
            this.controler = dialog.Combat;
            this.model = new CombatViewModel(controler.hrac, controler.enemy);


            this.DataContext = model;


        }

        private void Button_Click_Continue(object sender, RoutedEventArgs e)
        {
            if(model.BattleResult == 0)
                controler.hrac.level++;
            NavigationService.Navigate(new Pribeh(dialog.moznost[model.BattleResult].dialog, controler.hrac.level));

        }
        




    }
}
