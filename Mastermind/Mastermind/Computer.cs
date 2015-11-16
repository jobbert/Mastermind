using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mastermind{
    class Computer{
        private Random randomizer = new Random();
        public string[] colorSequence = new string[6];
        public int number;
        Kleur color;

        public Computer(){
            color = new Kleur(number);
        }

        public void setSequence() {
            for(int i = 0; i < colorSequence.Length; i++){
                colorSequence[i] = color.getColor();
            }
        }

        public void randomKleur() {
            int number = randomizer.Next(colorSequence.Length);
            this.number = number;
        }
    }
}
