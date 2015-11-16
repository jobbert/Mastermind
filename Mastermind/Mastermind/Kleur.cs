using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Kleur
    {
        //string[] colors = new string[6];
        string[] colors = { "", "", "", "", "", "" };
        public string kleur = "";

        public Kleur(int i)
        {
            setColor(i);
        }

        public void setColor(int i)
        {
            kleur = this.colors[i];
        }

        public string getColor()
        {
            return kleur;
        }
    }
}
