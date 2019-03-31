using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Dog:Animal
    {
        string name;
        string type = "dog";
        string noiseDog = "Woof Woof";

        public Dog(string name):base(name)
        {
            this.name = name;
        }

        string labDog = "              .--~~,__ \n" + " :-....,-------`~~'._.'\n" +
                           "  `-,,,  ,_      ;'~''              (\\\\)\n" + "   _,-' ,'`-__; '--.\n" +
                            "  (_/'~~      ''''(;\n";
        public override string Intro()

        {
            return $"Hello. My name is {name}.  I am a {type}.";
        }

        public override string Speak()
        {
            return noiseDog;
        }

        public void Fetch()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(labDog);
            Console.ResetColor();
        }
    }
}
