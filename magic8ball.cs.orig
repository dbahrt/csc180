// source: https://github.com/panditakshay/Magic-8-ball/blob/master/Magic-8-Ball/Program.cs
// author: Pandit Akshay
// summary: c# magic 8 ball game
// modifications: eliminated foul-mouthed insults and words;
// student: Dan Bahrt
// capture date: 3 Apr 2019


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic_8_Ball
{
    /// <summary>
    /// Entry point for Magic 8 Ball program 
    /// </summary>
    class Program
    {
        // Instantiate a randomObject to use later 
        static Random randomObject = new Random();

        // Preserve current console text color
        static ConsoleColor oldColor = Console.ForegroundColor;



        //Main method invoked 
        static void Main(string[] args)
        {
           
            programInfo();

            // Loop infinitely
            while (true)
            {
                string questionString = getQuestion();

                // make the computer pause for seconds
                // to create an illusion of thinking
                int numberOfSecondsToSleep = ((randomObject.Next(5) + 1) * 1000);
                Console.WriteLine("Thinking...");
                Thread.Sleep(numberOfSecondsToSleep);

                //Check if user entered question, if not run the loop back
                if ( questionString.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please type a question!");
                    continue;
                }

                //Quit the loop when user types "quit"
                if ( questionString.ToLower() == "quit")
                {
                    return;
                }

                definedBallReplies();
               
            }

            // Cleaning up
            Console.ForegroundColor = oldColor;
        }




        /// <summary>
        /// This will print the name of the program and the creator of it 
        /// </summary>
        static void programInfo()
        {
            // Change Console text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Magic ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("8 ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Ball ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("(By: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Pandit ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Akshay ");
            # Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
        }




        /// <summary>
        /// This function will return text the user types
        /// </summary>
        /// <returns></returns>
        static string getQuestion()
        {
            // This block of code will ask user for a question
            // and store the question text in questionString variable
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask a question?: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            String questionString = Console.ReadLine();

            return questionString;
        }



        /// <summary>
        /// This gives the random generated pre defined 8 ball replies
        /// out of 18 given replies
        /// </summary>
        static void definedBallReplies()
        {
            // Create a random # (0-19)
            // because 19 replies
            int randomNumber = randomObject.Next(19);

            // Use random number to determine response
            switch (randomNumber)
            {
                case 0:
                    {
                        Console.WriteLine("YES!");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("NO!");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("HELL NO!");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("HELL YES!");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("It is certain");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("It is decidedly so");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Without a doubt");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("You may rely on it");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Most likely!");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Outlook good!");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Reply hazy try again!");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("Ask again later");
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("Better not tell you now!");
                        break;
                    }
                case 13:
                    {
                        Console.WriteLine("Cannot predict now");
                        break;
                    }
                case 14:
                    {
                        Console.WriteLine("Concentrate and ask again");
                        break;
                    }
                case 15:
                    {
                        Console.WriteLine("Don't count on it");
                        break;
                    }
                case 16:
                    {
                        Console.WriteLine("My sources say no");
                        break;
                    }
                case 17:
                    {
                        Console.WriteLine("Outlook not so good");
                        break;
                    }
                case 18:
                    {
                        Console.WriteLine("Very doubtful");
                        break;
                    }
            }
        }
    }
}
