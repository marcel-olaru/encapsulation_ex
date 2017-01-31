using System;

namespace encapsulation_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Dog = new Animal(); // "new Animal();" is called the constructor.
            Dog.Age = 12;
            // Negative values are prevented by the if statement in the Animal class.
            Dog Spot = new Dog();
            Spot.Age = 5;
            Spot.name = "Spot";
            Console.WriteLine($" {Spot.name}'s age is {Spot.Age} y.o.");
            Dog.move();
            Dog.makeNoise();

            Console.ReadKey();
        }
    }
}

