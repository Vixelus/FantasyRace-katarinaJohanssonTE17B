using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRace
{
    class Unicorn: Animal
    { 
        public Unicorn()//variables
        {
            Random generator = new Random();
            Speed = generator.Next(9, 12);
            energyCurrent =10;
            energyMax = 10;
        }
        
    }
}
