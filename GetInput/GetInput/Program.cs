using System;

namespace GetInput
{
    internal class Program
    {

        static void Main()
        {
            string[] names = { "Bob", "Alex", "Adam", "Kate", "Steve" };
            Console.WriteLine($"Please type in the name you are looking for: ");
            string nameToLookFor = Console.ReadLine();
            Console.WriteLine($"Looking for {nameToLookFor} ... ");

            for (int i = 0; i < names.Length; i++)
            {
                if(names[i] == nameToLookFor)
                {
                    Console.WriteLine($"Found {nameToLookFor} at the index of {i}. ");
                    break;
                }

                if (i == names.Length - 1)
                {
                    Console.WriteLine($"could not find the {nameToLookFor} ...");
                }
            }
        }
    }
}