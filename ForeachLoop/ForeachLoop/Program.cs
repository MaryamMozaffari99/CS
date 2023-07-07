using System;

namespace ForeachLoop
{
    internal class Program
    {
        static void Main()
        {
            string[] names = {"Bob", "Alex", "Adam", "Kate", "Steve"};
            int i = 0;
            for (; i < names.Length;)
            {
                i ++;
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
