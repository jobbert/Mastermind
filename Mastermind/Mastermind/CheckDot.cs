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
        private Size DOT_SIZE = new Size(32, 32);

        public Checkdot(int number) {
            color = new Kleur(number);
            
        }
        
    }
}
