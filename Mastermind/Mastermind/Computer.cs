using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mastermind
{
    class Computer
    {
        private Random randomizer = new Random();
        public string[] colorSequence = new string[6];

        

        public void setSequence() {
            for(int i = 0; i < colorSequence.Length; i++)
            {
                //colorSequence[i] = 
            }
        }

        private int randomKleur() {
            int number = randomizer.Next(colorSequence.Length);
            return number;
        }
    }
}
