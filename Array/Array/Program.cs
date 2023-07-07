using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string nameOne = "Bob";      
            //string nameTwo = "Adam";      
            // array store names in one 
            string[] names = { "Bob", "Adam", "Kate", "Steve", "Sally", "Mary" };
            int[] ages = { 21, 32, 23, 45, 25, 27 };

            names[0] = "Ellen";

            Console.WriteLine(names[0]);
            Console.WriteLine(names.Length);
            Console.WriteLine(names[5]);
        }
    }
}
