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
        int Turns;
        //Form1 form = new Form1();
        
        public string[] sequence = new string[4];
        public string[] guess = new string[4];
        Object[,,] buttonrows;



        public Beurt (int turn, bool enabled) {
            Dot dot11 = new Dot(6);
            Dot dot12 = new Dot(6);
            Dot dot13 = new Dot(6);
            Dot dot14 = new Dot(6);

            Dot dot21 = new Dot(6);
            Dot dot22 = new Dot(6);
            Dot dot23 = new Dot(6);
            Dot dot24 = new Dot(6);

            Dot dot31 = new Dot(6);
            Dot dot32 = new Dot(6);
            Dot dot33 = new Dot(6);
            Dot dot34 = new Dot(6);

            Dot dot41 = new Dot(6);
            Dot dot42 = new Dot(6);
            Dot dot43 = new Dot(6);
            Dot dot44 = new Dot(6);

            Dot dot51 = new Dot(6);
            Dot dot52 = new Dot(6);
            Dot dot53 = new Dot(6);
            Dot dot54 = new Dot(6);

            Dot dot61 = new Dot(6);
            Dot dot62 = new Dot(6);
            Dot dot63 = new Dot(6);
            Dot dot64 = new Dot(6);

            Dot dot71 = new Dot(6);
            Dot dot72 = new Dot(6);
            Dot dot73 = new Dot(6);
            Dot dot74 = new Dot(6);

            Dot dot81 = new Dot(6);
            Dot dot82 = new Dot(6);
            Dot dot83 = new Dot(6);
            Dot dot84 = new Dot(6);

            Checkdot Checkdot11 = new Checkdot(6);
            Checkdot Checkdot12 = new Checkdot(6);
            Checkdot Checkdot13 = new Checkdot(6);
            Checkdot Checkdot14 = new Checkdot(6);

            Checkdot Checkdot21 = new Checkdot(6);
            Checkdot Checkdot22 = new Checkdot(6);
            Checkdot Checkdot23 = new Checkdot(6);
            Checkdot Checkdot24 = new Checkdot(6);

            Checkdot Checkdot31 = new Checkdot(6);
            Checkdot Checkdot32 = new Checkdot(6);
            Checkdot Checkdot33 = new Checkdot(6);
            Checkdot Checkdot34 = new Checkdot(6);

            Checkdot Checkdot41 = new Checkdot(6);
            Checkdot Checkdot42 = new Checkdot(6);
            Checkdot Checkdot43 = new Checkdot(6);
            Checkdot Checkdot44 = new Checkdot(6);

            Checkdot Checkdot51 = new Checkdot(6);
            Checkdot Checkdot52 = new Checkdot(6);
            Checkdot Checkdot53 = new Checkdot(6);
            Checkdot Checkdot54 = new Checkdot(6);

            Checkdot Checkdot61 = new Checkdot(6);
            Checkdot Checkdot62 = new Checkdot(6);
            Checkdot Checkdot63 = new Checkdot(6);
            Checkdot Checkdot64 = new Checkdot(6);

            Checkdot Checkdot71 = new Checkdot(6);
            Checkdot Checkdot72 = new Checkdot(6);
            Checkdot Checkdot73 = new Checkdot(6);
            Checkdot Checkdot74 = new Checkdot(6);

            Checkdot Checkdot81 = new Checkdot(6);
            Checkdot Checkdot82 = new Checkdot(6);
            Checkdot Checkdot83 = new Checkdot(6);
            Checkdot Checkdot84 = new Checkdot(6);

            buttonrows = new Object[8, 2, 4]
            {
                {
                    {dot11, dot12, dot13, dot14 }, {Checkdot11, Checkdot12, Checkdot13, Checkdot14 }
                }, {
                    {dot21, dot22, dot23, dot24 }, {Checkdot21, Checkdot22, Checkdot23, Checkdot24 }
                }, {
                    {dot31, dot32, dot33, dot34 }, {Checkdot31, Checkdot32, Checkdot33, Checkdot34 }
                }, {
                    {dot41, dot42, dot43, dot44 }, {Checkdot41, Checkdot42, Checkdot43, Checkdot44 }
                }, {
                    {dot51, dot52, dot53, dot54 }, {Checkdot51, Checkdot52, Checkdot53, Checkdot54 }
                }, {
                    {dot61, dot62, dot63, dot64 }, {Checkdot61, Checkdot62, Checkdot63, Checkdot64 }
                }, {
                    {dot71, dot72, dot73, dot74 }, {Checkdot71, Checkdot72, Checkdot73, Checkdot74 }
                }, {
                    {dot81, dot82, dot83, dot84 }, {Checkdot81, Checkdot82, Checkdot83, Checkdot84 }
                }
            };

            //int Turn = getTurn();
        }
        //public int getTurn() {
        //    setTurn(turns);
        //    return turns;
        //}

        //public void setTurn(int turn) {
        //    this.turns = turn;
        //    turns++;
        //    return turns;
        //}
        //public Turn()
        //{
        //    setTurn();
        //}

        public int setTurn()
        {
            Turns++;
            return Turns;
        }


        public void setSequence(int turn, out object[,,] buttonrows, bool enabled, string[] guess)
        {
            buttonrows = this.buttonrows;
            turn = this.Turns;
            enabled = this.enabled;
            guess = this.guess;

            for (int i = 0; i < guess.Length; i++)
            {
                //buttonrows[turn, 0, i]; 
            }
        }
        public int getTurn()
        {
            return Turns;

        }
    }
}
