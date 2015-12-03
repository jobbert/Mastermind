using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Mastermind
{
    class Beurt
    {
        bool enabled;
        int turns;

        string[] colorSequence;
        
        public Beurt (int turn, int y)
        {
            Point p1 = new Point(10, y);
            Panel dot1 = new Panel();
            dot1.PointToClient(p1);

            Point p2 = new Point(82, y);
            Panel dot2 = new Panel();
            dot2.PointToClient(p2);

            Point p3 = new Point(154, y);
            Panel dot3 = new Panel();
            dot3.PointToClient(p3);

            Point p4 = new Point(226, y);
            Panel dot4 = new Panel();
            dot4.PointToClient(p4);

            turn = getTurn();
        }
        public int getTurn() {
            return turns;
        }

        public void setSequence() {
            
        }
    }
}
