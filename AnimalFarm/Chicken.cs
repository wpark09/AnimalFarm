using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Chicken:Animal
    {
        string name;
        string type = "chicken";
        string noiseChicken = "Cluck Cluck";

        public Chicken(string name) : base(name)
        {
            this.name = name;
        }

        public override string Intro()

        {
            return $"Hello. My name is {name}.  I am a {type}.";
        }

        public override string Speak()
        {
            return noiseChicken;
        }

        public string Fly()
        {
            return "Chickens can FLY!!!";
        }
    }
}
