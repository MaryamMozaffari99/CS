using System;

namespace ForLoop
{
     static class Program
    {
        static void Main()
        {
            int age = 1;

            while (age < 18)
            {
                Console.WriteLine($"You are {age} years old, stay in school");
                age += 1;
            }
            Console.WriteLine("========================================================");
            //age ++ is the same as age += 1 ;
            for (int Age = 0; Age < 18; Age ++)
            {
                Console.WriteLine($"You are {Age} years old, stay in school");
            }

            Console.WriteLine("Now you are allowed to find a real job, or go to the " +
                "college");
        }
    }
}
