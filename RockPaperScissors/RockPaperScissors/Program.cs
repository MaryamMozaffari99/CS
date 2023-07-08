using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main()
        {
            string[] moves = { "Rock", "Paper", "Scissors" };
             
            Random rd = new Random();
            string computerMove = moves[rd.Next(0, moves.Length)];
            
            //Console.WriteLine($"the compuer picked: {moves[computerMove]}");

            Console.WriteLine($"Please pick your move : {moves[0]}, {moves[1]}, {moves[2]}");
            string playerMove = Console.ReadLine();

            while ( playerMove != moves[0] && playerMove != moves[1] && playerMove != moves[2] ) 
            {
                Console.WriteLine($"{playerMove} is not a valid move, Please pick: {moves[0]}, {moves[1]}, {moves[2]}");
                playerMove = Console.ReadLine(); 
            }
            Console.WriteLine($"Your pick ; {playerMove} , computer pick:{computerMove}  ");

            if (computerMove == playerMove)
            {
                Console.WriteLine($"This is the tie!HAHAHA");
            }
            else
            {
                bool playerWinConditionOne = playerMove == moves[0] && computerMove == moves[2];
                bool playerWinConditionTwo = playerMove == moves[1] && computerMove == moves[0];
                bool playerWinConditionThree = playerMove == moves[2] && computerMove == moves[1];

                if (playerWinConditionOne || playerWinConditionTwo || playerWinConditionThree)
                {
                    Console.WriteLine("You Win!");
                }
                else
                {
                    Console.WriteLine("You Lose.");
                }

            }
           
        }
    }
}
