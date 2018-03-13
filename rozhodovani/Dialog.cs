using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rozhodovani
{
   public class Dialog
    {

        public Combat_controler Combat;

        public List<string> texty;

        public List<Moznost> moznost;
        public Dialog(params string[] texty1)
         {
            texty = new List<string>();
            moznost = new List<Moznost>();
            foreach (string text in texty1) {

                texty.Add(text);
            }
        }

        public Dialog(bool combat, Player hrac, Enemy enemy) 
        {
            
            moznost = new List<Moznost>();
            Combat = new Combat_controler(combat, hrac, enemy);

        }


    }

    public class Moznost
    {
        public string decision;

        public Dialog dialog;
        public Moznost(string decision, Dialog dialog) { this.decision = decision; this.dialog = dialog; }
    }

}
