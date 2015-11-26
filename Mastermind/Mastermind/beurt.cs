using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Beurt
    {
        bool enabled;
        int turns;

        string[] colorSequence;
        
        public Beurt (int turn)
        {
            turn = getTurn();
        }
        public int getTurn() {
            return turns;
        }

        public void setSequence() {
            
        }
    }
}
