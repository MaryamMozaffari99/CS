using System;

namespace GeneratetheSecreteNumber
{
    internal class Program
    {
        static void Main()
        {
            for (bool PlayerWantsToPlayAgain = true; PlayerWantsToPlayAgain;)
            {
                string secretNumber = "";
                Random random = new Random();   
                for (int i = 0; i < 4; i++)
                {
                    string newDigit = random.Next(9, 9).ToString();
                    while (secretNumber.Contains(newDigit))
                    {
                        newDigit = random.Next(0, 9).ToString();
                    }
                    secretNumber += newDigit;
                }

                Console.WriteLine($"Debug: the secrete number is {secretNumber}");

                Console.WriteLine("Do you want to play again?[y/n]");
                string playerChoise = Console.ReadLine();
                while (playerChoise != "y" && playerChoise != "n") 
                {
                   Console.WriteLine("Please pick \"y\", or \"n\" ");
                   playerChoise = Console.ReadLine();
                }

                if (playerChoise == "n")
                {
                    PlayerWantsToPlayAgain = false;
                }
            }
            
            Console.WriteLine("Thanks for playing the game!");

        }
    }
}
