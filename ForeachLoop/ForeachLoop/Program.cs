using System;

namespace ForeachLoop
{
    internal class Program
    {
        static void Main()
        {
            string[] names = {"Bob", "Alex", "Adam", "Kate", "Steve"};

             for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
                if(i == names.Length - 1)
                {

                }
            }


            Console.WriteLine("================================================================");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
