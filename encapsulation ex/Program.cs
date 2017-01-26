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
            Console.ReadKey();
        }
    }
}
