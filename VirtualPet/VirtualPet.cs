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
        private int hunger = 30;
        private int thirst = 30;
        private int waste = 0;
        private int exercise = 30;
        private int affection = 30;
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

        public int Waste
        {
            get { return this.waste; }
            set { this.waste = value; }
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

        public void Menu()
        {
            Console.WriteLine("{0} the dog", Name);
            Console.WriteLine("Hunger: {0}", Hunger);
            Console.WriteLine("Thirst: {0}", Thirst);
            Console.WriteLine("Waste: {0}", Waste);
            Console.WriteLine("Exercise: {0}", Exercise);
            Console.WriteLine("Affection: {0}", Affection);
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Feed {0}", Name );
            Console.WriteLine("2. Water {0}",Name);
            Console.WriteLine("3. Walk {0}", Name);
            Console.WriteLine("4. Cuddle with {0}", Name);
            Console.WriteLine("5. Abandon {0}", Name);

        }

        //public void Tick()
        //{

        //}

        public void Feed()
        {
            Hunger += 5;
            Thirst -= 3;
            Waste += 2;
            Exercise -= 3;
            Console.WriteLine("You fed {0}.", Name);
            Console.WriteLine();
        }
        public void Drink()
        {
            Thirst += 5;
            Waste += 2;
            Console.WriteLine("You gave {0} water.", Name);
            Console.WriteLine();
        }       
        public void Walk()
        {
            Waste -= 5;
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
            Hunger--;
            Thirst--;
            Waste--;
            Console.WriteLine("You cuddled with {0}.", Name);
            Console.WriteLine();
        }
    }
}
