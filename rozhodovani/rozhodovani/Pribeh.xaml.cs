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
    /// Interakční logika pro Pribeh.xaml
    /// </summary>
    public partial class Pribeh : Page
    {
        public Player player;
        public Dialog currentdialog;
        public int index = 0;
        public Pribeh(Dialog dialog = null, int level = 1)
        {


            InitializeComponent();
            player = new Player(level);
            Player_level.Content = player.level;
            Dialog dialog1 = new Dialog( "Vítej ve hře", "chceš přiblížit o co v příběhu jde ? ");

            Dialog dialog2 = new Dialog( "Člověk, opovrhovaná rasa. Téměř všichni lidé byli vyvražděni nebo zneškodněni.", "Celému světu panuje Temný lord, který rozhoduje o osudu lidí. Nikdo ho však neviděl bez jeho brnění a masky.", "Každý den se zbytky lidí převáží na popraviště, kde se jich zbavuje.", "A zde začíná příběh Frankieho, který byl 3 roky mučen a  byly mu dávány drogy, aby zapomněl na svoji minulost", "jsi ready?");

            Dialog dialog3 = new Dialog( "Vzbudil ses a zjistil si, že se nacházíš ve voze na popravu.", "Všichni okolo tebe jsou vystrašení, co uděláš ?");


            Dialog dialog4 = new Dialog(true, player, new Enemy(player.level, "Bandit" , Enemy.Type.BASIC));

            Dialog dialog5 = new Dialog( "vyhrals");


            dialog1.moznost.Add(new Moznost("ano", dialog2));

            dialog1.moznost.Add(new Moznost("ne", dialog3));



            dialog2.moznost.Add(new Moznost("ano", dialog3));

            dialog2.moznost.Add(new Moznost("ano", dialog3));



            dialog3.moznost.Add(new Moznost("lehnout si a nic neřešit", dialog4));

            dialog3.moznost.Add(new Moznost("", dialog1));



            dialog4.moznost.Add(new Moznost("vyhrál jsi", dialog5));

            dialog4.moznost.Add(new Moznost("prohrál jsi", dialog3));


            dialog5.moznost.Add(new Moznost("rofl", dialog5));

            dialog5.moznost.Add(new Moznost("lol", dialog3));






            currentdialog = dialog3;
            if (dialog != null)
            {
                currentdialog = dialog;
            }
            loaddialog();


        }

        private void loaddialog()
        {
            //if (currentdialog.Combat != null)

               // NavigationService.Navigate(new Combat(currentdialog));
            //else {
                question.Text = currentdialog.texty[index];

                if (currentdialog.moznost.Count > 1)
                {
                    bttn1.Content = currentdialog.moznost[0].decision;
                    bttn2.Content = currentdialog.moznost[1].decision;
                }
            //}



        }

        private void Next_Dialog(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string decision = button.Content.ToString();

            Moznost moznost = currentdialog.moznost.Find(moz => moz.decision == decision);
            currentdialog = moznost.dialog;

            bttn3.IsEnabled = true;
            bttn1.Visibility = Visibility.Hidden;
            bttn2.Visibility = Visibility.Hidden;
            index = 0;
            loaddialog();

        }

        private void Next_Text(object sender, RoutedEventArgs e)
        {
            index++;
            if (index >= currentdialog.texty.Count - 1)
            {
                bttn3.IsEnabled = false;
                bttn1.Visibility = Visibility.Visible;
                bttn2.Visibility = Visibility.Visible;
            }


            loaddialog();


        }
    }
}
