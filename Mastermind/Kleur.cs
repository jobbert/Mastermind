using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Kleur
    {
        public string[] colors = new string[6];
        public string[] colors = {"black.png", "bleu.png", "green.png", "red.png", "white.png", "yellow.png"};
        public string kleur = "";

        public Kleur(int i)
        {
            setColor(i);
        }

        public string setColor(int i)
        {
            kleur = this.colors[i];
        }

        public string getColor()
        {
            return kleur;
        }
    }
}
