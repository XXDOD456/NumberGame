using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my game!");
            Console.WriteLine("Can you guess my favorite number?");
            int num = 362;
            var userInput  = int.Parse(Console.ReadLine());
            if (num < userInput)
            {
                Console.WriteLine("Sorry, too high!");
            }
            else if (num > userInput)
            {
                Console.WriteLine("Sorry, too low!");
            }
            else
            {
                Console.WriteLine("That's right!");
            }
        }
    }
}
