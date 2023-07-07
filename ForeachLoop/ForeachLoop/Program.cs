using System;
using System.Xml.Linq;

namespace ForeachLoop
{
    internal class Program
    {
        static void Main()
        {
            string[] names = {"Bob", "Alex", "Adam", "Kate", "Steve"};
            int i = 0;
            for (; ;)
            {
                if (names[i] == "Adam")
                {
                    Console.WriteLine("Found Adam!");
                    break;
                }

                i++;

            }
            //which is like whileLoop

            Console.WriteLine("================================================================");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
