﻿using System;

namespace SwitchandEnums
{
    internal class Program
    {
        enum groupSize
        {
            small, 
            medium,
            big
        }

        static void Main(string[] args)
        {


            //int numberOfStudents = 10;

            //string groupSize = "small";

            //switch(numberOfStudents)

            groupSize size = groupSize.small;   


            switch (size)
            {
                //case 10:
                case groupSize.small:
                    Console.WriteLine("Hey!We are going to the small facility");
                    break;
                //case 30:
                case groupSize.medium:
                    Console.WriteLine("Hey!We are going to the medium facility");
                    break;
                //case 100:
                case groupSize.big:
                    Console.WriteLine("Hey!We are going to the big facility");
                    break;
                default:
                    Console.WriteLine("Let's plan where to go");
                    break;
            }
        }
    }
}
