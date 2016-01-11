using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Mastermind
{
    class Dot : Label
    {
        private Size DOT_SIZE = new Size(64, 64);
        Kleur color;

        public Dot(int number) {
            Size grootte = DOT_SIZE;
            color = new Kleur(number);
            color.setColor(number);
        }


    }
}
