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
        private int x;
        private int y;
        Point position;
        
        int number;
        
        public Checkdot(Kleur color, Point positie) {
            color = new Kleur(number);
            positie = position;
        }

        public void setPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
            position = new Point(x, y);
        }

        public Point getPosition()
        {
            return position;
        }
        
        public bool ckeckPosition(Dot punt) {
            return true;
        }
        
    }
}
