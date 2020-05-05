using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRace
{
    class Animal
    {
        public int Position = 0;
        static Random generator = new Random();
            
        public int Speed;
        public int energyCurrent;
        public int energyMax;
       
        public void Move()
        {   
            if(energyCurrent>0)//moves if the current energy of the animal is over 0
            {
                Position += generator.Next(1, Speed +1 );
                energyCurrent--;


                if (Position>20)//This makes it so that the position cant go over 20
                {
                    Position = 20;
                }
                if (energyCurrent<0)// this makes it so that the energy cant go under 0
                {
                    energyCurrent = 0;
                }
            }
           

        }
        public  void Rest()// when you rest you get back all your energy
        {
            energyCurrent = energyMax;
            
        }
        public void Printstats()//prints the stats of an animal
        {
            Console.WriteLine("Speed: " + Speed );
            Console.WriteLine("Position: " + Position);
            Console.WriteLine("Energy: " + energyCurrent +"/"+ energyMax);
        }
    }
}
