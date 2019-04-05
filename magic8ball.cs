// source: https://github.com/panditakshay/Magic-8-ball/blob/master/Magic-8-Ball/Program.cs
// author: Pandit Akshay
// summary: c# magic 8 ball game
// modifications: eliminated foul-mouthed insults and words; eliminated comments;
//     condensed braces; 
// student: Dan Bahrt
// capture date: 3 Apr 2019


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic_8_Ball {

class Program {
    static Random randomObject = new Random();

    static ConsoleColor oldColor = Console.ForegroundColor;

    static void Main(string[] args) {
           
        programInfo();

        while (true) {
            string questionString = getQuestion();

            int numberOfSecondsToSleep = ((randomObject.Next(5) + 1) * 1000);
            Console.WriteLine("Thinking...");
            Thread.Sleep(numberOfSecondsToSleep);

            if ( questionString.Length == 0) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please type a question!");
                continue;
            }

            if ( questionString.ToLower() == "quit") {
                return;
            }

            definedBallReplies();
               
        }

        Console.ForegroundColor = oldColor;
    }

    static void programInfo() {
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

    static string getQuestion() {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Ask a question?: ");
        Console.ForegroundColor = ConsoleColor.Gray;
        String questionString = Console.ReadLine();
        return questionString;
    }

    static void definedBallReplies() {
        int randomNumber = randomObject.Next(19);

        switch (randomNumber) {
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
                    break;                }
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
