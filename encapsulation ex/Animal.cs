using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_ex
{
    class Animal
    {
        private string type;
        private string color;
        private string weight;
        private string height;
        
        private int NumOfLegs;
        public virtual void move() // The methods are public in order to be available for calling.
        {
            Console.WriteLine("Moved");
        }
        public void makeNoise()
        {
            Console.WriteLine("Made noise");
        }


        private int age; // This cannot be assigned in Main because of the private scope. Member variables are not capitalized.
        public int Age // This on the other hand can. This is a property and is capitalized. It is "int" because it returns an integer.
        {
            get { return this.age; } 
            // This returns the age from Main. "this" means me, my specific intance. It can work without "this". It is used to 
            // specify that it is the age from this class and not some inherited one.
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age cannot be less than 0.");
                }
                else
                {
                    this.age = value;
                    // Value is a special keyword used in public properties to indicate the incident of the value passed in by 
                    // the user of our code. Keyword used to bring the age value into the age property.
                    Console.WriteLine($"your animal's age is {age}");
                }
            }
        }
    }
}
