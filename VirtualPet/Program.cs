using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool caredFor = true;            
            Console.WriteLine("What is your pet's name?");
            VirtualPet dog = new VirtualPet(Console.ReadLine());
           
            Console.WriteLine();
            while (caredFor == true)
            {        
                //display pet's current status
                Console.WriteLine("{0} the dog", dog.Name);
                Console.WriteLine("Hunger: {0}", dog.Hunger);
                Console.WriteLine("Thirst: {0}", dog.Thirst);
                Console.WriteLine("Exercise: {0}", dog.Exercise);
                Console.WriteLine("Affection: {0}", dog.Affection);
                Console.WriteLine();

                //displays options to interact with pet
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Feed {0}", dog.Name);
                Console.WriteLine("2. Water {0}", dog.Name);
                Console.WriteLine("3. Walk {0}", dog.Name);
                Console.WriteLine("4. Cuddle with {0}", dog.Name);
                Console.WriteLine("5. Abandon {0}", dog.Name);
                Console.WriteLine();
                
                //takes in user's selection
                int input = int.Parse(Console.ReadLine());
                dog.Tick();

                //user's selection triggers an action
                switch (input)
                {
                    case (1):
                        dog.Feed();
                        break;
                    case (2):
                        dog.Drink();
                        break;
                    case (3):
                        dog.Walk();
                        break;
                    case (4):
                        dog.Cuddle();
                        break;
                    case (5):
                        caredFor = false;
                        Console.WriteLine("{0} is better without you anyway.",dog.Name);
                        break;
                    default:
                        break;
                }

                if (dog.Hunger <= 0 || dog.Thirst <= 0 || dog.Affection <= 0 || dog.Exercise <= 0)
                {
                    caredFor = false;
                    Console.WriteLine("{0} felt neglected and ran away to find a better home.", dog.Name);
                }
            }
        }
    }
}
