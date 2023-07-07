using System;

namespace GetInput
{
    internal class Program
    {

        static void Main()
        {
            string[] names = { "Bob", "Alex", "Adam", "Kate", "Steve" };
            Console.WriteLine($"Please type in the name you are looking for: ");
            string indexAsString = Console.ReadLine();
            int indexToLookFor = Convert.ToInt32( indexAsString );  
            Console.WriteLine($"Looking for a name at index {indexAsString} ... ");

            if (indexToLookFor >= 0 && indexToLookFor < names.Length ) 
            {
                Console.WriteLine($"Found name {names[indexToLookFor]} ...");
            }
            else
            {
                Console.WriteLine($"could not find ... ");
            }
        }
    }
}