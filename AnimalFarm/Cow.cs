using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Cow : Animal
    {
        string name;
        string type = "cow";
        string noiseCow = "Moo~~~~";

        public Cow(string name) : base(name)
        {
            this.name = name;
        }
        public override string Intro()

        {
            return $"Hello. My name is {name}.  I am a {type}.";
        }

        public override string Speak()
        {
            return noiseCow;
        }

        public void ProduceMilk()
        {
            Console.WriteLine("A Gallon of Strawberry milk for you.");
        }
    
    }
}
