using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind{
    class Computer{
        private Random randomizer = new Random();
        public string[] colorSequence = new string[4];
        public int number;
        Kleur color;

        public Computer(){
            
        }

        public void setSequence() {
            for(int i = 0; i < colorSequence.Length; i++){
                color = new Kleur(randomKleur());
                colorSequence[i] = color.getColor();
            }
        }

        public string[] getSequence() {
            return colorSequence;
        }

        public int randomKleur() {
            int number = randomizer.Next(5);
            this.number = number;
            return number;
        }
    }
}
