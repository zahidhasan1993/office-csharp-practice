using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_practice
{
   class Animal
    {
        public string name;
        public string sound;
       static int numOfAnimals = 0;

        public Animal()
        {
            name = "No Name";
            sound = "No Sound";
            numOfAnimals++;
        }
        public Animal(string name = "NO NAME")
        {
            this.name = name;
            this.sound = "NO SOUND";
            numOfAnimals++;
        }
        public Animal(string name = "NO NAME", string sound = "NO SOUND")
        {
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }
        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

       public static int TotalAnimals()
        {
            return numOfAnimals;
        }
    }
}
