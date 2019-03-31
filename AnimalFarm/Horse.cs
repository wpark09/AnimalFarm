using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Horse: Animal
    {
        string name;
        string type = "horse";
        string noiseHorse = "NEIGHHHH";
        public Horse (string name) : base(name)
        {
            this.name = name;
        }
        public override string Intro()

        {
            return $"Hello. My name is {name}. I am a {type}.";
        }
        public override string Speak()
        {
            return noiseHorse;

        }

        internal void Ride()
        {
            Console.WriteLine("\n\n\nClip-clop Clip-clop Clip-clop Clip-clop... HALT. \nYou have arrived."); 
        }
    }
}
