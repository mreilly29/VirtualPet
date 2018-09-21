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
            VirtualPet dog = new VirtualPet();
            Console.WriteLine("What is your pet's name?");            
            dog.Name = Console.ReadLine();
            Console.WriteLine();
            while (caredFor == true)
            {                
                Console.WriteLine("{0} the dog", dog.Name);
                Console.WriteLine("Hunger: {0}", dog.Hunger);
                Console.WriteLine("Thirst: {0}", dog.Thirst);
                Console.WriteLine("Exercise: {0}", dog.Exercise);
                Console.WriteLine("Affection: {0}", dog.Affection);
                Console.WriteLine();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Feed {0}", dog.Name);
                Console.WriteLine("2. Water {0}", dog.Name);
                Console.WriteLine("3. Walk {0}", dog.Name);
                Console.WriteLine("4. Cuddle with {0}", dog.Name);
                Console.WriteLine("5. Abandon {0}", dog.Name);
                Console.WriteLine();
                int input = int.Parse(Console.ReadLine());
                dog.Tick();
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
                        break;
                    default:
                        break;
                }

                if (dog.Hunger == 0 || dog.Thirst == 0)
                {
                    caredFor = false;
                }
            }
        }
    }
}
