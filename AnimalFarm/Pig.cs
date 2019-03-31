using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Pig:Animal
    {
        string name;
        public Pig(string name):base(name)
        {
            this.name = name;
        }

        public void Oink()
        {
            Console.WriteLine($"{name} says: Oink Oink. Oink.");
        }
    }
}
