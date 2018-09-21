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
            Hunger += 5;
            Thirst -= 3;
            Exercise -= 3;
            Affection++;
            Console.WriteLine("You fed {0}.", Name);
            Console.WriteLine();
        }
        public void Drink()
        {
            Thirst += 5;
            exercise--;
            Affection--;
            Console.WriteLine("You gave {0} water.", Name);
            Console.WriteLine();
        }       
        public void Walk()
        {
            Exercise += 5;
            Hunger--;
            Thirst -= 5;
            Affection += 2;
            Console.WriteLine("You walked {0}.", Name);
            Console.WriteLine();
        }
        public void Cuddle()
        {
            Affection += 6;
            Exercise--;
            Console.WriteLine("You cuddled with {0}.", Name);
            Console.WriteLine();
        }

        public void Tick()
        {
            Hunger -=2;
            Thirst --;            
            Exercise--;
            Affection--;
        }
    }
}
