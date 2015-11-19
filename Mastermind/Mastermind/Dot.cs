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
        private int x;
        private int y;
        private Size DOT_SIZE = new Size(20, 20);
        public Point position;
        public void setPosition(int x, int y){
            this.x = x; 
            this.y = y;
            position = new Point(x, y);
        }

        public Point getPosition()
        {
            return position;
        }
    }
}
