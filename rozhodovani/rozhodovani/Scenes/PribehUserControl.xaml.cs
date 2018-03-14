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
    /// Interakční logika pro PribehUserControl.xaml
    /// </summary>
    public partial class PribehUserControl : UserControl
    {
        public PribehUserControl(Dialog dialog = null,int level = 0)
            
        {
            InitializeComponent();
            DataContext = new StoryViewModel(dialog, level);

        }
    }
}
