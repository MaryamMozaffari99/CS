﻿using System;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string messageOne = "Hello MARY!";
            string messageTwo = " Another One!";
            string combian = messageOne + messageTwo;
            //System.Int64 wholeNumber = 2340782758947;
            int wholeNumber = 4 ;
            int numberTwo = 5;
            int subtraction = wholeNumber - numberTwo;
            int addition = wholeNumber + numberTwo;
            int multiply = wholeNumber * numberTwo;
            int times = wholeNumber ^ numberTwo;
            float divisionOne = wholeNumber / numberTwo;
            float divisionTwo =(float) wholeNumber / numberTwo;
            float divisionThree =(float) wholeNumber /(float) numberTwo;

            int module = wholeNumber % numberTwo;   

            float complicateExpression =multiply - ((wholeNumber + numberTwo) / subtraction);

            float floatNumber = 3.57837937458974839578345847589f;
            double doubleNumber = 3.58798748798347589738957483975843;

            int floatToInt = (int) floatNumber;

            char letterA = 'A';

            bool falseBool = false;
            bool trueBool = true;

            bool andBothTrue = trueBool && trueBool;
            bool andBothFalse = falseBool && falseBool;
            bool andOneTrue = trueBool && falseBool;
            bool andOtherTrue = falseBool && trueBool;  
            
            bool orBothTrue = trueBool || trueBool; 
            bool orBothFalse = falseBool || falseBool;
            bool orOneTrue = trueBool || falseBool;
            bool orOtherTrue = falseBool || trueBool;


             
            Console.WriteLine("Hello World!");
            Console.WriteLine(messageOne);
            Console.WriteLine(wholeNumber);
            Console.WriteLine(floatNumber);
            Console.WriteLine(doubleNumber);
            Console.WriteLine(letterA);
            Console.WriteLine(falseBool);
            Console.WriteLine(trueBool);
            Console.WriteLine(addition);
            Console.WriteLine(subtraction);
            Console.WriteLine(multiply);
            Console.WriteLine(times);
            Console.WriteLine(divisionOne);
            Console.WriteLine(divisionTwo);
            Console.WriteLine(divisionThree);
            Console.WriteLine(floatToInt);
            Console.WriteLine(module);
            Console.WriteLine(combian); 
            Console.WriteLine(andBothTrue); 
            Console.WriteLine(andBothFalse); 
            Console.WriteLine(andOneTrue); 
            Console.WriteLine(andOtherTrue); 
            Console.WriteLine(orBothTrue); 
            Console.WriteLine(orBothFalse); 
            Console.WriteLine(orOneTrue); 
            Console.WriteLine(orOtherTrue);    
            Console.WriteLine(complicateExpression);    
        }
    }
}