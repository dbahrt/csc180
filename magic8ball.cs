// source: https://github.com/panditakshay/Magic-8-ball/blob/master/Magic-8-Ball/Program.cs
// author: Pandit Akshay
// summary: c# magic 8 ball game
// modifications: eliminated foul-mouthed insults and words; eliminated comments;
//     condensed braces; changed predictions switch for a simple array lookup; 
// student: Dan Bahrt
// capture date: 3 Apr 2019


using System;
using System.Threading;

namespace Magic_8_Ball {

//==========
class Program {

    static string [] predictions = {
        "YES!",
        "NO!",
        "HELL NO!",
        "HELL YES!",
        "It is certain",
        "It is decidedly so",
        "Without a doubt",
        "You may rely on it",
        "Most likely!",
        "Outlook good!",
        "Reply hazy try again!",
        "Ask again later",
        "Better not tell you now!",
        "Cannot predict now",
        "Concentrate and ask again",
        "Don't count on it",
        "My sources say no",
        "Outlook not so good",
        "Very doubtful",
    };

    static Random randomObject = new Random();

    static ConsoleColor oldColor = Console.ForegroundColor;

    //----------
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
                break;
            }

            definedBallReplies();
               
        }

        Console.ForegroundColor = oldColor;
    } // end function Main()

    //----------
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
        // Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine();
    } // end function programInfo()

    //----------
    static string getQuestion() {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Ask a question?: ");
        Console.ForegroundColor = ConsoleColor.Gray;
        String questionString = Console.ReadLine();
        return questionString;
    } // end function getQuestion()

    //----------
    static void definedBallReplies() {
        Console.ForegroundColor = ConsoleColor.Cyan;

        int randomNumber = randomObject.Next(19);
        Console.WriteLine(predictions[randomNumber]);
        Console.WriteLine();
    } // end function definedBallReplies()
} // end class Program
    
} // end namespace Magic_8_Ball
