using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Check
    {
        public string[] guess = new string[4];
        public string[] sequence = new string[4];

        public Check(string[] guess, string[] sequence)
        //public Check()
        {
            //guess[0] = "black.png";
            //guess[1] = "blue.png";
            //guess[2] = "green.png";
            //guess[3] = "yellow.png";

            //sequence[0] = "black.png";
            //sequence[1] = "blue.png";
            //sequence[2] = "green.png";
            //sequence[3] = "yellow.png";

            int p = 0;
            int c = 0;

            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == sequence[i] && sequence[i] != null)
                {
                    guess[i] = null;
                    sequence[i] = null;
                    p++;
                }
            }
            for (int i = 0; i < guess.Length; i++)
            {
                int z = Array.IndexOf(sequence, guess[i]);
                if (guess[i] == sequence[z])
                {
                    guess[i] = null;
                    sequence[z] = null;
                    c++;
                }
            }
            Console.WriteLine("p = " + p);
            Console.WriteLine("c = " + c);


        }
    }
}
