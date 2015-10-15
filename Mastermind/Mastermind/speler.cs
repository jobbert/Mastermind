using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class speler
    {
        private string naam;

        public speler()
        {

        }

        public speler(string naam) {
            setNaam(naam);
        }
        public void setNaam(string naam) {
            this.naam = naam;
        
        }

        public string getNaam() {
            return naam;
        }


    }
}
