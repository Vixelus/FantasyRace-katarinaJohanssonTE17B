using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRace
{
    class TeddyBear: Animal
    {
        public TeddyBear()//variables
        {
            Random generator = new Random();
            Speed = generator.Next(2,6) ;
           energyCurrent=17;
           energyMax = 17;
        }
        
    }
}
