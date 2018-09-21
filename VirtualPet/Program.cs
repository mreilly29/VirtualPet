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
            while (caredFor == true)
            {
                dog.Menu();
                int input = int.Parse(Console.ReadLine());
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


                if(dog.Hunger == 0 || dog.Thirst == 0)
                {
                    caredFor = false;
                }
            }
        }
    }
}
