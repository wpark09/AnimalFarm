using System;

namespace AnimalFarm
{
    public class App
    {
        Horse mustang = new Horse("Mustang");
        Cow strawBerryMilk = new Cow("Strawberry Milk");
        Dog bowWow = new Dog("Beethoven");
        Chicken mcNugget = new Chicken("Golden McNugget");
        Pig bacon = new Pig("BLT");
        Animal quitter = new Animal("Quit");
        public App()
        {          

        }

        public void Run()
        {
            Animal[] fantasticFour = { mustang, strawBerryMilk, bowWow, mcNugget, quitter};

            Console.WriteLine("Welcome to the Animal Farm!\n\n\n");

            foreach (var fantasic in fantasticFour)
            {
                Console.WriteLine($"{fantasic.Intro()} {fantasic.Speak()}\n");
            }
            bacon.Oink();

            Console.WriteLine("\nAnimal friends would like to show you some tricks!" +
                "\n\nAre you ready?!" +
                "\n\n\nPress enter to continue...");
            Console.ReadKey();
            Console.Clear();
            bool quit = false;

            do
            {
                var selection = quitter.Controller(fantasticFour);

                switch (selection)

                {
                    case 0:
                        mustang.Ride();
                        break;
                    case 1:
                        strawBerryMilk.ProduceMilk();
                        break;
                    case 2:
                        bowWow.Fetch();
                        break;
                    case 3:
                        Console.WriteLine("\n\n\n\n\n\n\n\n"+mcNugget.Fly());
                        break;
                    case 4:
                        Console.WriteLine("Good Bye.");
                        quit = true;
                        break;
                }
            Console.ReadKey();
            Console.Clear();

            } while (!quit);
        }


        }
    }