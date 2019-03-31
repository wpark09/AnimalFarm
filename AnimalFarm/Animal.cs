using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Animal
    {
        string[] animalFarm = { "Dog", "Cow", "Chicken", "Horse", "Pig" };
        string soundOfAnimal;
        string introduction;
        string name;
        int selectedAnimal = 0;
        public Animal(string name)
        {
            this.name = name;
        }

        public virtual string Speak()
        {
            return soundOfAnimal;
        }

        public virtual string Intro()
        {
            return introduction;
        }

        public void AnimalList(Animal[] animals)
        {

            for (int i = 0; i < animals.Length; ++i)
            {
                Console.WriteLine("");
                if (i == selectedAnimal)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.WriteLine(animals[i].name);

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public int Controller(Animal[] animals)
        {
            bool quit = false;

            do
            {
                Console.WriteLine("\nWho's trick do you want to see?\n");
                AnimalList(animals);
                var key = Console.ReadKey().Key;
                Console.Clear();
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        selectedAnimal -= 1;
                        if (selectedAnimal < 0)
                        {
                            selectedAnimal = animals.Length;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        selectedAnimal += 1;
                        if (selectedAnimal >= animals.Length)
                        {
                            selectedAnimal = 0;
                        }
                        break;
                    case ConsoleKey.Enter:
                        quit = true;
                        break;

                }
            } while (!quit);

            return selectedAnimal;
        }
    }
}
