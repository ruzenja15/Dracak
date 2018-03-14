using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace rozhodovani
{
    class StoryViewModel : AViewModel
    {
        public Player player;
        public Dialog currentdialog;
        public int index = 0;
        public Dictionary<string, Dialog> Dialogy;

        public StoryViewModel(Dialog dialog = null, int level = 1) {
           // UserControlView = new PribehUserControl();
            


            Dialogy = new Dictionary<string, Dialog>();
            Nexttext = new NextTextCommand(this);
            Nextdialog = new NextDialogCommand(this);
            


            player = new Player(level);
            

            setdialogs();


            currentdialog = Dialogy["dialog3"];
            Text = currentdialog.texty[index];
            Visibility = Visibility.Hidden;
            Enabled = true;


            Firstdecision = currentdialog.moznost[0].decision;
            Seconddecision = currentdialog.moznost[1].decision;




            if (dialog != null)
            {
                currentdialog = dialog;

            }
        

        }
        private string text;
        public string Text
        {
            get { return text; }
            set
            {
                if (text != value)
                {
                    text = value;
                    OnPropertyChanged("Text");
                }
            }
        }

        private string firstdecision;
        public string Firstdecision
        {
            get { return firstdecision; }
            set
            {
                if (firstdecision != value)
                {
                    firstdecision = value;
                    OnPropertyChanged("Firstdecision");
                }
            }
        }

        private string seconddecision;
        public string Seconddecision
        {
            get { return seconddecision; }
            set
            {
                if (seconddecision != value)
                {
                    seconddecision = value;
                    OnPropertyChanged("Seconddecision");
                }
            }
        }


        private Visibility visibility;
        public Visibility Visibility
        {
            get { return visibility; }
            set
            {
                if (visibility != value)
                {
                    visibility = value;
                    OnPropertyChanged("Visibility");
                }
            }
        }

        private bool enabled;
        public bool Enabled
        {
            get { return enabled; }
            set
            {
                if (enabled != value)
                {
                    enabled = value;
                    OnPropertyChanged("Enabled");
                }
            }
        }







































        private UserControl userControlView;
        public UserControl UserControlView
        {
            get { return userControlView; }
            set
            {
                if (userControlView != value)
                {
                    userControlView = value;
                    OnPropertyChanged("UserControlView");
                }
            }
        }



        private NextDialogCommand nextdialog;
        public NextDialogCommand Nextdialog
        {
            get { return nextdialog; }
            set
            {
                if (nextdialog != value)
                {
                    nextdialog = value;
                    OnPropertyChanged("Nextdialog");
                }
            }
        }




        private NextTextCommand nexttext;
        public NextTextCommand Nexttext
        {
            get {
                
                return nexttext; }
            set
            {
                if (nexttext != value)
                {
                    nexttext = value;
                    OnPropertyChanged("Nexttext");
                }
            }
        }


        private void setdialogs()
        {

            Dialogy.Add("dialog1", new Dialog("dialog1-1", "dialog1-2 "));

            Dialogy.Add("dialog2", new Dialog("dialog2-1 ", "dialog2-2 "));

            Dialogy.Add("dialog3", new Dialog("dialog3-1", "dialog3-2 "));


            Dialogy.Add("dialog5", new Dialog(true, player, new Enemy(player.level, "Bandit", Enemy.Type.BASIC)));

            Dialogy.Add("dialog4", new Dialog("dialog4-1", "dialog4-2 "));


            Dialogy["dialog1"].moznost.Add(new Moznost("pls", Dialogy["dialog2"]));

            Dialogy["dialog1"].moznost.Add(new Moznost("oh yeah", Dialogy["dialog3"]));



            Dialogy["dialog2"].moznost.Add(new Moznost("ehm ehm ehm", Dialogy["dialog3"]));

            Dialogy["dialog2"].moznost.Add(new Moznost("NONONO", Dialogy["dialog3"]));



            Dialogy["dialog3"].moznost.Add(new Moznost("lehnout si a nic neřešit", Dialogy["dialog5"]));

            Dialogy["dialog3"].moznost.Add(new Moznost("no cus", Dialogy["dialog1"]));



            Dialogy["dialog4"].moznost.Add(new Moznost("vyhrál jsi", Dialogy["dialog5"]));

            Dialogy["dialog4"].moznost.Add(new Moznost("prohrál jsi", Dialogy["dialog3"]));


            Dialogy["dialog5"].moznost.Add(new Moznost("rofl", Dialogy["dialog5"]));

            Dialogy["dialog5"].moznost.Add(new Moznost("lol", Dialogy["dialog3"]));


        }





    }
}
