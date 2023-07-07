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


        }
    }
}
