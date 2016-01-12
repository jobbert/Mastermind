using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{
    class Check
    {
        //public string[] guess = new string[4];
        //public string[] sequence = new string[4];

        public Check(string[] guess, string[] sequence)
        {
            //guess[0] = "black.png";
            //guess[1] = "blue.png";
            //guess[2] = "green.png";
            //guess[3] = "yellow.png";

            //sequence[0] = "black.png";
            //sequence[1] = "yellow.png"; 
            //sequence[2] = "green.png";
            //sequence[3] = "blue.png"; 

            int p = 0;
            int c = 0;

            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == sequence[i] && sequence[i] != null)
                {
                    MessageBox.Show(guess[i].ToString());
                    MessageBox.Show(sequence[i].ToString());
                    guess[i] = null;
                    sequence[i] = null;
                    p++;
                }
                //MessageBox.Show("p = " + p);
            }
            for (int i = 0; i < guess.Length; i++)
            {
                int z = Array.IndexOf(sequence, guess[i]);
                //MessageBox.Show("z : " + z.ToString());
                //if (guess[i] == sequence[Array.IndexOf(sequence, guess[i])] && guess[i] != null)
                if (Array.IndexOf(sequence, guess[i]) != -1 && guess[i] != null)
                    {
                    sequence[Array.IndexOf(sequence, guess[i])] = null;
                    guess[i] = null;
                    c++;
                }
                //MessageBox.Show("c = " + c.ToString());
            }
            MessageBox.Show
            (
                "p = " + p.ToString()
                + "\n" +
                "c = " + c.ToString()
            );
        }
    }
}
