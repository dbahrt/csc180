// source: Hands-On Object-Oriented Programming with C#
// author: Raihan Taher
// summary: Adding the digits of a number.
// modifications: Implemented a loop and converted int to long for endless math fun!
// student: Nathan Bonilla
// capture date: 05 Apr 2019


using System;

namespace sumOfDigitsInANumber
{
    class Program
    {
        static void Main(string[] args)
        //The entry point of the program.
        {
            while (true)
            //The following code block will execute as long as the if statement at the end is true.
            {
                long sum = 0;
                //Declaring sum as a long equivalent to 0.
                Console.WriteLine("Enter a Number : ");
                //Instructs the user to input numbers for the program to calculate.
                long num = long.Parse(Console.ReadLine());
                //Converts the user's input from a string to a long variable type.
                while (num != 0)
                //As long as num is not equal to 0, the following code block will repeat.
                {
                    long r = num % 10;
                    //r is the remainder of the user's number when divided by 10.
                    num = num / 10;
                    //num is then divided by 10.
                    sum = sum + r;
                    //r is added to the sum.
                    Console.WriteLine("sum = {0}", sum);
                }
                Console.WriteLine("Sum of Digits of the Number : " + sum);
                //Program shows the user the sum of digits in a number.
                Console.WriteLine("Try again?  (Y/N) ");
                //Program gives user choice to enter another number to calculate.
                if (Console.ReadLine().ToLower() != "y")
                //Program will loop if user enters "y".
                    break;
                    //Will break loop if the user enters anything other than "y".
            }
        }
    }
}
