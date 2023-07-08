using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main()
        {
            string[] moves = { "Rock", "Paper", "Scissors" };
            for (int i = 0; i < 10; i++)
            {
                Random rd = new Random();
                int computerChoice = rd.Next(0, moves.Length);
                Console.WriteLine($"the compuer picked: {moves[computerChoice]}");

               // string playerMove = Console.ReadLine();




            }
        }
    }
}
