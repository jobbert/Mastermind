using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Mastermind
{
    class Checkdot : Label
    {
        Kleur color;
        private int x;
        private int y;
        private Size DOT_SIZE = new Size(32, 32);
        public Point position;

        public Checkdot(int number) {
            color = new Kleur(number);
            
        }
        
    }
}
