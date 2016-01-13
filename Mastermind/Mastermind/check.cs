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
        int p = 0;
        int c = 0;
        //public string[] guess = new string[4];
        //public string[] sequence = new string[4];

        public Check(string[] guess, string[] sequence)
        {
            string[] guessableSequence = sequence;
            MessageBox.Show("guess : \n" + guess[0] + '\n' + guess[1] + '\n' + guess[2] + '\n' + guess[3]);
            MessageBox.Show("sequence : \n" + guessableSequence[0] + '\n' + guessableSequence[1] + '\n' + guessableSequence[2] + '\n' + guessableSequence[3]);
            //guess[0] = "black.png";
            //guess[1] = "blue.png";
            //guess[2] = "green.png";
            //guess[3] = "yellow.png";

            //sequence[0] = "black.png";
            //sequence[1] = "yellow.png";
            //sequence[2] = "green.png";
            //sequence[3] = "blue.png";


            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == sequence[i] && sequence[i] != null)
                {
                    //MessageBox.Show(guess[i].ToString());
                    //MessageBox.Show(sequence[i].ToString());
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
            getScore();
            MessageBox.Show
            (
                "p = " + p.ToString()
                + "\n" +
                "c = " + c.ToString()
            );

        }
        public int getScore()
        {
            return p;
        }
    }
}
