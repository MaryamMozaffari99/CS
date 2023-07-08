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
                    string newDigit = random.Next(0, 9).ToString();
                    while (secretNumber.Contains(newDigit))
                    {
                        newDigit = random.Next(0, 9).ToString();
                    }
                    secretNumber += newDigit;
                }

                Console.WriteLine("Please type your guess (4 digits, no repetition)");

                string playerGuess = Console.ReadLine();
                
                while (true)
                {
                    bool isFourDigits = playerGuess.Length == 4;
                    bool isAllDigit = true;
                    foreach(char digit in playerGuess)
                    {
                        if(!Char.IsDigit(digit))
                        {
                            isAllDigit = false;
                            break;
                        }
                    }


                    bool hasNoRepetition = true;
                    for( int i = 0; i < playerGuess.Length; i++)
                    {
                        for (int j = 0; j < playerGuess.Length; j++)
                        {
                            if (j != i && playerGuess[i] == playerGuess[j])
                            {
                                hasNoRepetition = false;
                                break;
                            }
                        }
                        if (!hasNoRepetition)
                        {
                            break;
                        }
                    }
                    if(isAllDigit && isFourDigits && hasNoRepetition)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The input is invalid, Please type you guess (4 digits number with no repetition)");
                        playerGuess = Console.ReadLine();
                    }
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
