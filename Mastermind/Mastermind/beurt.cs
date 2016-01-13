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
        Button[,,] buttonrows;

        

        public Beurt (Form1 form) {
            Button dot11 = new Button();
            Button dot12 = new Button();
            Button dot13 = new Button();
            Button dot14 = new Button();

            Button Checkdot11 = new Button();
            Button Checkdot12 = new Button();
            Button Checkdot13 = new Button();
            Button Checkdot14 = new Button();

            Button dot21 = new Button();
            Button dot22 = new Button();
            Button dot23 = new Button();
            Button dot24 = new Button();

            Button Checkdot21 = new Button();
            Button Checkdot22 = new Button();
            Button Checkdot23 = new Button();
            Button Checkdot24 = new Button();

            Button dot31 = new Button();
            Button dot32 = new Button();
            Button dot33 = new Button();
            Button dot34 = new Button();

            Button Checkdot31 = new Button();
            Button Checkdot32 = new Button();
            Button Checkdot33 = new Button();
            Button Checkdot34 = new Button();

            Button dot41 = new Button();
            Button dot42 = new Button();
            Button dot43 = new Button();
            Button dot44 = new Button();

            Button Checkdot41 = new Button();
            Button Checkdot42 = new Button();
            Button Checkdot43 = new Button();
            Button Checkdot44 = new Button();

            Button dot51 = new Button();
            Button dot52 = new Button();
            Button dot53 = new Button();
            Button dot54 = new Button();

            Button Checkdot51 = new Button();
            Button Checkdot52 = new Button();
            Button Checkdot53 = new Button();
            Button Checkdot54 = new Button();

            Button dot61 = new Button();
            Button dot62 = new Button();
            Button dot63 = new Button();
            Button dot64 = new Button();

            Button Checkdot61 = new Button();
            Button Checkdot62 = new Button();
            Button Checkdot63 = new Button();
            Button Checkdot64 = new Button();

            Button dot71 = new Button();
            Button dot72 = new Button();
            Button dot73 = new Button();
            Button dot74 = new Button();

            Button Checkdot71 = new Button();
            Button Checkdot72 = new Button();
            Button Checkdot73 = new Button();
            Button Checkdot74 = new Button();

            Button dot81 = new Button();
            Button dot82 = new Button();
            Button dot83 = new Button();
            Button dot84 = new Button();

            Button Checkdot81 = new Button();
            Button Checkdot82 = new Button();
            Button Checkdot83 = new Button();
            Button Checkdot84 = new Button();
            

            buttonrows = new Button[8, 2, 4]
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


        public void setSequence(int turn, string[] guess)
        {
            MessageBox.Show("turn : " + turn);
            MessageBox.Show("guess : [" + guess[0]+ ", " + guess[1] + ", " + guess[2] + ", " + guess[3] + "]");
            for (int i = 0; i < guess.Length; i++)
            {
                MessageBox.Show("i : " + i);

                string Val = guess[i];
                //MessageBox.Show("guess[" + i + "] : " + guess[i]);
                buttonrows[turn, 0, i].BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(guess[i]);
            }
        }

        public int getTurn()
        {
            return Turns;

        }
    }
}
