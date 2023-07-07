using System;

namespace IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string nameOne = "Bob";      
            //string nameTwo = "Adam";      
            // array store names in one 
            //string[] names = { "Bob", "Adam", "Kate", "Sally", "Ellen"};
            //int[] ages = { 21, 32, 23, 45, 25, 27 };
            //names[0] = "Ellen";

            /* if(names.Length > 0)
             {
                 Console.WriteLine(names[0]);
                 Console.WriteLine(names.Length);
                 Console.WriteLine(names[names.Length - 1]);
                 Console.WriteLine(names[4]);
             }*/
            /*if(true)
            {
                Console.WriteLine(names[0]);
                Console.WriteLine(names.Length);
                Console.WriteLine(names[names.Length - 1]);
                Console.WriteLine(names[4]);
            }*/
            int playerAge = 14;

            if(playerAge > 16) 
            {
                Console.WriteLine("You are allowed to play the game.");
            }
            else if(playerAge == 16)
            {
                Console.WriteLine("You are allowed to play for one hour!");
            }
            else if (playerAge == 15)
            {
                Console.WriteLine("You are allowed to play for 30 minutes!");
            }
            else
            {
                Console.WriteLine("You are not allowed play the game.");
            }
        }
    }
}
