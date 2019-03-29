// SOURCE: https://www.sanfoundry.com/csharp-programs-gaming-hangman/
// AUTHOR: Manish Bhojasia, a technology veteran with 20+ years @ Cisco &
//     Wipro, [along with consultancies at IBM, Brocade, Quantum, etc.]
//     is Founder and CTO at Sanfoundry. He is Linux Kernel Developer and
//     SAN Architect and is passionate about competency development....
//     He lives in Bangalore ....
// FILENAME: hangman.orig
// PURPOSE: C# Program to Create a Hangman Game
// STUDENT: Dan Bahrt
// DATE: 08 Feb 2019

// STYLE MODIFICATIONS: none

// FUNCTIONAL MODIFICATIONS: none


/*
 *  C# Program to Create a HangMan Game
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("Welcome to Hangman!!!!!!!!!!");
            string[] listwords = new string[10];
            listwords[0] = "sheep";
            listwords[1] = "goat";
            listwords[2] = "computer";
            listwords[3] = "america";
            listwords[4] = "watermelon";
            listwords[5] = "icecream";
            listwords[6] = "jasmine";
            listwords[7] = "pineapple";
            listwords[8] = "orange";
            listwords[9] = "mango";
            Random randGen = new Random();
            var idx = randGen.Next(0, 9);
            string mysteryWord = listwords[idx];
            char[] guess = new char[mysteryWord.Length];
            Console.Write("Please enter your guess: ");
 
            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '*';
 
            while (true)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    if (playerGuess == mysteryWord[j])
                        guess[j] = playerGuess;
                }
                Console.WriteLine(guess);
            }
        }
    }
}
