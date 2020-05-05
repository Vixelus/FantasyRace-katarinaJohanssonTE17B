using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Random generator = new Random();
            
            int round = 0;
            Animal A = new Animal();
            Unicorn U = new Unicorn();
            TeddyBear TB = new TeddyBear();
           

            


            Console.WriteLine("How many animals do you want to particiapate in this race?");
            Console.WriteLine("Write a number:");
            string answer = Console.ReadLine();
            
            
            bool intResultTryParse = int.TryParse(answer, out result);
            while  (intResultTryParse == false)//while the answer is not a number it will keep telling you to write in a number
            {
                Console.WriteLine("Please write a number");
                string ans = Console.ReadLine();//need this here so that the if will be able to break the loop
                bool TryParse = int.TryParse(ans, out result);
                if (TryParse == true)
                {
                    break;
                    //breaks the loop and jumps to the thing under
                }
            }
            if (intResultTryParse == true)
            {
                Console.WriteLine("Created "+ answer+ " constestants:");
                Console.ReadKey();
            }
            Console.Clear();
            // makes animals


            List<Animal> animalList = new List<Animal>();
           

            for (int i = 0; i < result; i++)// this makes sure the method gets looped as many times as the user requested
            {
                int random = generator.Next(11);
                if (random < 5)//creates a unicorn if number is lower than 5
                {
                    Console.WriteLine("Added Unicorn to the race!");
                    U.Printstats();
                    Console.WriteLine("-----------------------------------------------");
                    animalList.Add(new Unicorn());
                    Console.ReadKey();
                }
                else if (random > 6)//creates a teddy if number is higher than 6
                {
                    Console.WriteLine("Added Teddybear to the race!");
                    TB.Printstats();
                    Console.WriteLine("----------------------------------------------");
                    animalList.Add(new TeddyBear());
                    Console.ReadKey();
                }
                
            }
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadKey();
                Console.Clear();
            Animal race = animalList[generator.Next(animalList.Count)];//chooses a random animal from the list to compete

            while(true)
            {
                Console.WriteLine("Round:" +round);//writes out the current round
                race.Printstats();//prints out stats for this current round
                Console.WriteLine("----------------------------------------------");
                while(true)
                {
                    Console.WriteLine("1= Move, 2= Rest");
                    answer = Console.ReadLine();
                    string y = "1";
                    string n = "2";
                    int.TryParse(answer, out result);
                    if( answer == y)//makes you move
                    {
                        race.Move();
                        Console.WriteLine("The animal moved");
                        Console.ReadKey();
                        round++;//after every move the number of rounds go up
                        break;
                    }
                    else if (answer==n)//lets you recover energy1
                    {
                        race.Rest();
                        Console.WriteLine("The animal is resting");
                        Console.ReadKey();
                        round++;
                        break;
                    }
                    if (race.Position ==20)// if the animal reaches this position it breaks the loop
                    {
                        break;
                    }
                }

                if (race.Position == 20)// if the animal reaches this position it breaks the loop
                {
                    break;
                }
            }

            Console.WriteLine("Wooo, u won!!");

            Console.ReadLine();



        }
    }
}
