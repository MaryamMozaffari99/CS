using System;

namespace IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            int playerAge = 16;
            bool isParentWithplayer = false;

            int timeOfTheDay = 17;

            if(!(playerAge > 16) || isParentWithplayer && false) 
            {
                Console.WriteLine("You are allowed to play the game.");
            }
            else if(playerAge == 16 && timeOfTheDay > 21)
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
