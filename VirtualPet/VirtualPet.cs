using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //FIELDS
        private int hunger = 25;
        private int thirst = 25;
        private int exercise = 25;
        private int affection = 25;
        private string name;

        //PROPERTIES
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }
        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }
        public int Exercise
        {
            get { return this.exercise; }
            set { this.exercise = value; }
        }
        public int Affection
        {
            get { return this.affection; }
            set { this.affection = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //CONSTRUCTORS
        public VirtualPet()
        {
            //defualt constructor
        }

        public VirtualPet(string petName)
        {
            Name = petName;
        }

        //METHODS
        public void Feed()
        {
            Hunger += 7;
            Thirst -= 2;
            Exercise -= 2;
            Affection--;
            Console.WriteLine("You fed {0}.", Name);
            Console.WriteLine();
        }
        public void Drink()
        {
            Thirst += 10;
            exercise--;
            Affection--;
            Console.WriteLine("You gave {0} water.", Name);
            Console.WriteLine();
        }       
        public void Walk()
        {
            Exercise += 10;
            Hunger--;
            Thirst -= 3;
            Affection += 2;
            Console.WriteLine("You walked {0}.", Name);
            Console.WriteLine();
        }
        public void Cuddle()
        {
            Affection += 7;
            Console.WriteLine("You cuddled with {0}.", Name);
            Console.WriteLine();
        }

        public void Tick()
        {        
            Hunger --;          
            Exercise -= 2;
            Affection -= 2;
            Thirst --;
        }
    }
}
