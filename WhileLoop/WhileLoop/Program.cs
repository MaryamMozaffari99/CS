using System;

namespace WhileLoop
{
    class Program
    {
        static void Main()
        {
            int age = 1;

            while (age < 18)
            {
                Console.WriteLine("You are {age} years old, stay in school");
                // this is the same as age = age + 1;
                age += 1;
               // age = age + 1;  
            }
            Console.WriteLine("Now you are allowed to find a real job, or go to the college"); 
        }
    }
}


